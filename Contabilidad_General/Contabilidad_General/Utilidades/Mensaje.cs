using System;
using Gtk;

namespace Contabilidad_General.Utilidades
{
    public class Mensaje
    {
        public void ShowMessage(Window parent, string title, string message)
        {
            Dialog dialog = null;
            try
            {
                dialog = new Dialog(title, parent, DialogFlags.DestroyWithParent | DialogFlags.Modal, ResponseType.Ok);
                dialog.VBox.Add(new Label(message));
                dialog.ShowAll();

                dialog.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (dialog != null)
                {
                    dialog.Destroy();
                }
            }
        }
        public Mensaje()
        {
        }
    }
}
