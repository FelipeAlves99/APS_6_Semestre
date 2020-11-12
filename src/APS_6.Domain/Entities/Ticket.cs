using APS_6.Domain.Enums;
using System;

namespace APS_6.Domain.Entities
{
    public class Ticket : Entity
    {
        public Ticket(double value, string description, Guid companyId, RuralProperty ruralProperty)
        {
            CreationDate = DateTime.Now;
            DeadlineDate = DateTime.Now.AddMonths(6);
            Value = value;
            Description = description;
            Status = ETicketStatus.Open;
            CompanyId = companyId;
            RuralProperty = ruralProperty;
        }

        public DateTime CreationDate { get; }
        public DateTime DeadlineDate { get; }
        public double Value { get; private set; }
        public string Description { get; private set; }
        public ETicketStatus Status { get; private set; }
        public Guid CompanyId { get; private set; }
        public RuralProperty RuralProperty { get; private set; }

        public void UpdateTicketStatus(ETicketStatus status)
        {
            if (Status == ETicketStatus.Closed)
                AddNotification(nameof(Status), "A multa já está fechada, não é possível atualizar seu status");
            else
                Status = status;
        }

    }
}
