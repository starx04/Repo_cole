/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app_viajeestudiantil_af;

import javax.swing.JOptionPane;

/**
 *
 * @author UELD-USER-19
 */
public class APP_ViajeEstudiantil_AF {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int est,pre = 0,tot;
        est=Integer.parseInt(JOptionPane.showInputDialog("Ingrese el numero de estudiantes que van a ir al viaje:"));
        if (est>=100)
            {
            pre= 65;
        tot= pre*est;
            JOptionPane.showMessageDialog(null,"El viaje sera de "+est+",entonces su precio es de "+pre+" en total el precio recaudado es de"+tot);
            }
            else if (est<=99)
                {
            pre= 70;
        tot= pre*est;
            JOptionPane.showMessageDialog(null,"El viaje sera de "+est+",entonces su precio es de "+pre+" en total el precio recaudado es de"+tot);
}            
            else if (est<=49)
    {
                pre=95;
        tot= pre*est;
            JOptionPane.showMessageDialog(null,"El viaje sera de "+est+",entonces su precio es de "+pre+" en total el precio recaudado es de"+tot);
}            
else if (est<=30)
    {
                pre=4000;
        tot= pre;
            JOptionPane.showMessageDialog(null,"El viaje sera de "+est+",entonces su precio es de "+pre+" en total el precio a pagar sera de"+tot);
    
}
}
    }

    

