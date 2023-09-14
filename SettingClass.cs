using System;


namespace visokoe

{ 
public class MySetting
{
    private int set_port;


        public MySetting()
        {
            InitialSetting(set_port);
        }


    public int SetPort
    {
        get => set_port;

        set
        {
            set_port = value;
           
        }
    }

        public void InitialSetting(int port)
        { set_port = port; }

}
}