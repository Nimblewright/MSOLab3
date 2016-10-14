using System;
using System.Windows.Forms;

namespace Lab3
{
    public class IKEAMyntAtare2000
    {
        public void starta()
        {
            //MessageBox.Show ("Välkommen till IKEA Mynt Ätare 2000");
        }

        public void stoppa()
        {
            //MessageBox.Show ("Hejdå!");
        }

        public void betala(int pris)
        {
            //MessageBox.Show (pris + " cent");
        }
    }

    public class CoinMachine : IKEAMyntAtare2000
    {
        public void Initialize()
        {
            starta();
            MessageBox.Show("Welcome. Please insert the cash in the slot.");
        }

        public void FinishPayment()
        {
            stoppa();
            MessageBox.Show("Enjoy your trip!");
        }

        public void HandlePayment(double price)
        {
            int priceCent = (int)(price * 100);
            betala(priceCent);
            MessageBox.Show("Price: €" + (price / 100).ToString("0.00"));
        }
    }
}

