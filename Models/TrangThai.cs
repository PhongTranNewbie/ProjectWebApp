namespace Khachsan.Models
{
    public class TrangThai
    {
        private string _matrangthai;
        public string matrangthai
        {
            get { return _matrangthai; }
            set
            {
                if (value.Length < 5)
                {
                    _matrangthai = value;
                }
            }
        }
        private string _tentrangthai;
        public string tentrangthai
        {
            get { return _tentrangthai; }
            set
            {
                if (value.Length < 10)
                {
                    _tentrangthai = value;
                }
            }
        }
    }
}
