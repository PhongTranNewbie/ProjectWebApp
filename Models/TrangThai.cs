namespace Khachsan.Models
{
    public class TrangThai
    {
        public string matrangthai
        {
            get
            {
                return matrangthai;
            }
            set
            {
                if(value.Length <5 )
                {
                    matrangthai = value;
                }
            }

        }
        public string tentrangthai
        {
            get
            {
                return tentrangthai;
            }
            set
            {
                if( value.Length < 10 )
                {
                    tentrangthai = value;
                }    
            }
        }
    }
}
