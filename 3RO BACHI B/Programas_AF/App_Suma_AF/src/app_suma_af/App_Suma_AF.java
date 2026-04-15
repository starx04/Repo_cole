/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app_suma_af;

import javax.swing.JOptionPane;

/**
 *
 * @author PC
 */
public class App_Suma_AF {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int num1,num2,sum;
        num1=Integer.parseInt(JOptionPane.showInputDialog("Ingrese nota 1:"));
        num2=Integer.parseInt(JOptionPane.showInputDialog("Ingrese nota 2:"));
        sum=(num1+num2);
        JOptionPane.showMessageDialog(null,"La suma es: "+sum);
    }
    
}
