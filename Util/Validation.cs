using System;
using System.Linq;
using prjMaestroDetalle.Models;

namespace prjMaestroDetalle.Util
{
    public class Validation
    {
        public Validation()
        {

        }
       public bool IsValiCedula(string Cedula)
        {
            int vnTotal = 0;
            string vcCedula = Cedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (vcCedula.Equals("00000000000"))
                if (pLongCed < 11 || pLongCed > 11)
                    return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

         public  bool ExistCedula(string Cedula)
         {
             try
             {
                 if(IsValidCedula(Cedula))
                  {
                   var Cliente = Context.Cliente.FirstOrDefault(x => x.Cedula.Equals(Cedula));
                   if(Cliente != null)
                   {
                       return true;
                   }
                 }
             }
             catch (Exception ex)
             {   
                 Console.Write("ocurrio un error" + ex);
             }
             return false;
         }
    }
}
