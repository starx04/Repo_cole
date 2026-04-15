/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app_horas_extra_af;

import javax.swing.JOptionPane;

/**
 *
 * @author PC
 */
public class App_Horas_Extra_AF {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int h,hx = 0;
        h=Integer.parseInt(JOptionPane.showInputDialog("Ingrese las horas trabajadas:"));
        hx=h-12;
        if (h>12)
            JOptionPane.showMessageDialog(null,"El indice de horas a trabajar es 12 y usted a ingresado "+h+",entonces usted a trabajado "+hx+" horas extra");
        else if (h==12)
            JOptionPane.showMessageDialog(null,"A cumplido con el indice de horas a trabajar que son: "+h);
        else if (h<12)
            JOptionPane.showMessageDialog(null,"No ha cumplido con el indice de horas a trabajar que es 12 y usted a ingresado "+h+" horas trabajadas");
    }
    
}
