namespace petronet.efatura.api.core.Integration.Command.Interfaces
{
    public class ServiceResponse {
        public bool Hatali { get; set; }
        public string Istisna { get; set; }
        public object Data { get; set; }
        public string Sonuc { get; set; }
    }
}