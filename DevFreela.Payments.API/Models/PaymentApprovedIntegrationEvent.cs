namespace DevFreela.Payments.API.Models
{
    public class PaymentApprovedIntegrationEvent
    {
        public int IdProject { get; }

        public PaymentApprovedIntegrationEvent(int idProject)
        {
            IdProject = idProject;
        }
    }
}
