/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app_sueldo_af;

import javax.swing.JOptionPane;

/**
 *
 * @author PC
 */
public class App_Sueldo_AF {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int sue,h,ph;
        ph=Integer.parseInt(JOptionPane.showInputDialog("Ingrese el pago por hora:"));
        h=Integer.parseInt(JOptionPane.showInputDialog("Ingrese las horas trabajadas:"));
        sue=(ph*h);
        JOptionPane.showMessageDialog(null,"El sueldo es de : "+sue);
    }
    
}
