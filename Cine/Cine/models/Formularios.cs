using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cine.views;

namespace Cine.models
{
    class Formularios
    {
        public void SeleccionarFormulario(int value, object id)
        {
            switch (value)
            {
                case 1:
                    new frMantenimiento(id).Show();
                    break;
                default:
                    break;
            }
        }
        public void SeleccionarFormularioDelete(int value, object id)
        {
            switch (value)
            {
                case 1:
                    new frDelete(id).Show();
                    break;
                default:
                    break;
            }
        }
    }
}
