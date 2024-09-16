using System;

public class Alarmclock
{
  
    
    public event EventHandler onAlarming;
    public DateTime Horaestablecida { get; set; }

    public void versieslahora(DateTime horaquees)
    {
        if (horaquees.Hour == Horaestablecida.Hour && horaquees.Minute == Horaestablecida.Minute && horaquees.Second == Horaestablecida.Second)
        {
            onAlarming.Invoke(this, EventArgs.Empty);
        }
    }
}


public class Correr
{
    public static void Main(string[] args)
    {
        Alarmclock Nose = new Alarmclock();
        Nose.Horaestablecida = DateTime.Now.AddSeconds(10);
        Nose.onAlarming += etediparatenosuena;
        DateTime comenzar = DateTime.Now;
        while (true)
        {
            Nose.versieslahora(DateTime.Now);
            if (DateTime.Now >= Nose.Horaestablecida)
            {
                break;
            }

        }

    }
    private static void etediparatenosuena(object sender, EventArgs e)
    {
        Console.WriteLine("Si, el Disparate al fin sono");
    }
}