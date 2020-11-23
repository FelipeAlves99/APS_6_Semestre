import cv2
import os
import sys
import numpy
import argparse
import matplotlib.pyplot as plt
from random import randrange
from enhance import image_enhance
from skimage.morphology import skeletonize, thin

ap = argparse.ArgumentParser()

ap.add_argument("-un", "--user-name", help="The user name labeled in the fingerprint dataset")
ap.add_argument("-fp", "--fingerprint-path", help="The fingerprint path to compare with user dataset")

args = vars(ap.parse_args())

def main():
    image_name = args["fingerprint_path"]
    fingerprint_img = cv2.imread(image_name, cv2.IMREAD_GRAYSCALE)
    #print(fingerprint_img)
    kp1, des1 = get_descriptors(fingerprint_img)    

    image_name = "C:/Users/FELIPEDECARVALHOALVE/repos/APS_6_Semestre/src/APS.FirgerprintRecognition/dataset/" + args["user_name"] + "/" + str(randrange(5)) + ".png"
    user_fingerprint = cv2.imread(image_name, cv2.IMREAD_GRAYSCALE)
    #print(user_fingerprint)
    kp2, des2 = get_descriptors(user_fingerprint)

    bf = cv2.BFMatcher(cv2.NORM_HAMMING, crossCheck=True)
    matches = sorted(bf.match(des1, des2), key=lambda match:match.distance)

    fingerprint_keypoints = cv2.drawKeypoints(fingerprint_img, kp1, outImage=None) 
    user_keypoints = cv2.drawKeypoints(user_fingerprint, kp2, outImage=None)
    f, axarr = plt.subplots(1,2)
    axarr[0].imshow(fingerprint_keypoints)
    axarr[1].imshow(user_keypoints)
    plt.show()

    fingerprint_matches = cv2.drawMatches(fingerprint_img, kp1, user_fingerprint, kp2, matches, flags=2, outImg=None)
    plt.imshow(fingerprint_matches)
    plt.show()

    #Score calculation
    score = 0
    for match in matches:
        score += match.distance
    score_threshold = 33
    if score/len(matches) < score_threshold:
        print("Matched")
    else:
        print("Failed")

def get_descriptors(img):
    clahe = cv2.createCLAHE(clipLimit=2.0, tileGridSize=(8,8))
    img = clahe.apply(img)
    img = image_enhance.image_enhance(img)
    img = numpy.array(img, dtype=numpy.uint8)
    # Threshold
    ret, img = cv2.threshold(img, 127, 255, cv2.THRESH_BINARY_INV | cv2.THRESH_OTSU)
    # Normalize to 0 and 1 range
    img[img == 255] = 1

    #Thinning
    skeleton = skeletonize(img)
    skeleton = numpy.array(skeleton, dtype=numpy.uint8)
    skeleton = removedot(skeleton)
    # Harris corners
    harris_corners = cv2.cornerHarris(img, 3, 3, 0.04)
    harris_normalized = cv2.normalize(harris_corners, 0, 255, norm_type=cv2.NORM_MINMAX, dtype=cv2.CV_32FC1)
    threshold_harris = 125
    # Extract keypoints
    keypoints = []
    for x in range(0, harris_normalized.shape[0]):
        for y in range(0, harris_normalized.shape[1]):
            if harris_normalized[x][y] > threshold_harris:
                keypoints.append(cv2.KeyPoint(y, x, 1))
    # Define descriptor
    orb = cv2.ORB_create()
    # Compute descriptors
    _, des = orb.compute(img, keypoints)
    return (keypoints, des);

def removedot(invertThin):
    temp0 = numpy.array(invertThin[:])
    temp0 = numpy.array(temp0)
    temp1 = temp0/255
    temp2 = numpy.array(temp1)
    temp3 = numpy.array(temp2)

    enhanced_img = numpy.array(temp0)
    filter0 = numpy.zeros((10,10))
    W,H = temp0.shape[:2]
    filtersize = 6

    for i in range(W - filtersize):
        for j in range(H - filtersize):
            filter0 = temp1[i:i + filtersize,j:j + filtersize]

            flag = 0
            if sum(filter0[:,0]) == 0:
                flag +=1
            if sum(filter0[:,filtersize - 1]) == 0:
                flag +=1
            if sum(filter0[0,:]) == 0:
                flag +=1
            if sum(filter0[filtersize - 1,:]) == 0:
                flag +=1
            if flag > 3:
                temp2[i:i + filtersize, j:j + filtersize] = numpy.zeros((filtersize, filtersize))

    return temp2

if __name__ == "__main__":
    try:
        main()
    except:
        raise