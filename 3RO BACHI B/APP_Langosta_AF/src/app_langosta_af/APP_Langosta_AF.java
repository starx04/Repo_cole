/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app_langosta_af;

import javax.swing.JOptionPane;

/**
 *
 * @author UELD-USER-19
 */
public class APP_Langosta_AF {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
         int per,pre = 0,tot;
        per=Integer.parseInt(JOptionPane.showInputDialog("Ingrese las personas a reservar para el evento:"));
        if (per<=200)
            pre= 95;
        tot= pre*per;
            JOptionPane.showMessageDialog(null,"El evento sera de "+per+",entonces su precio es de "+pre+" en total el precio sera de"+tot);
            if (per<=300)
            pre= 85;
        tot= pre*per;
            JOptionPane.showMessageDialog(null,"El evento sera de "+per+",entonces su precio es de "+pre+" en total el precio sera de"+tot);
        if (per>300)
                pre=75;
        tot= pre*per;
            JOptionPane.showMessageDialog(null,"El evento sera de "+per+",entonces su precio es de "+pre+" en total el precio sera de"+tot);
        
    }
    
}
