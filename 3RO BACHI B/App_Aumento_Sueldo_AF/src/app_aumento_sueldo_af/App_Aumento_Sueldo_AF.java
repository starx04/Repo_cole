/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app_aumento_sueldo_af;

/**
 *
 * @author PC
 */
public class App_Aumento_Sueldo_AF {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        double sue,aum,tot;
        string nom;
        JoptionPane.showMessageDialog(null,"Calculo de sueldo");
        nom=JoptionPane.showImputDialog("Ingrese su nombre: ");
        sue=Double.parseDouble(JoptionPane.showImputDialog("Ingrese su nombre: "));
        if (sue<1000);
               {
                aum= sue*0.15;
                tot= sue+aum;
                
               }
                else
                {
                        aum=sue*0.12;
                tot=sue+aum;
                        }
                JoptionPane.showMessageDialog(null,"tu sueldo es "+sue+"\n y tu aumento correspondiente es de "+aum+"\n y eso da un sueldo total de "+tot);
    }
    
}
