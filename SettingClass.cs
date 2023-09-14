using System;


namespace visokoe

{ 
public class MySetting
{
    private int _port;


        public MySetting(int port = 8888)

        {
            _port = port;
            
        }


    public int Port
    {
        get => _port;

        set
        {
            _port = value;
           
        }
    }

  

}
}