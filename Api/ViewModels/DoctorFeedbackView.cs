namespace Api.ViewModels
{
    public class DoctorFeedbackView
    {
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public string Content { get; set; }
        public int Stars { get; set; }
    }
}
