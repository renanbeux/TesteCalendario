using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TesteCalendario
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            calendar.Locale = new System.Globalization.CultureInfo("pt-BR");

            calendar.ShowInlineEvents = true;
            CalendarInlineEvent events = new CalendarInlineEvent
            {
                StartTime = new DateTime(2018, 9, 3, 5, 0, 0),
                EndTime = new DateTime(2018, 9, 3, 5, 0, 0),
                Subject = "Go to Meeting",
                Color = Color.Fuchsia
            };

            CalendarEventCollection collection = new CalendarEventCollection();
            collection.Add(events);
            calendar.DataSource = collection;


            List<DateTime> black_dates = new List<DateTime>();
            black_dates.Add(new DateTime(2018, 9, 10));
            calendar.BlackoutDates = black_dates;


            // this.Content = calendar;


        }
        
        public void MostraCompromisso(object sender, Syncfusion.SfCalendar.XForms.InlineToggledEventArgs args)
        {
            try
            {
                CalendarEventCollection collection = (CalendarEventCollection)args.selectedAppointment;
                CalendarInlineEvent evento = collection[0];

                if (evento != null)
                {
                    cDesc.Text = evento.Subject.ToString();
                    cHora.Text = evento.StartTime.ToString();
                    cCor.Color = evento.Color;
                }
                else
                    DisplayAlert("Erro", "Nullo", "OK");

            }
            catch(Exception e)
            {
                DisplayAlert("Erro",e.StackTrace + "\n" + e.InnerException + "\n" + e.Message, "OK");
            }
        }

    }
}
