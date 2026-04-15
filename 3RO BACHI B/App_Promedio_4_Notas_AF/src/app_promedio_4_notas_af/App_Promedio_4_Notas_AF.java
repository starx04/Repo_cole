/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app_promedio_4_notas_af;

import javax.swing.JOptionPane;

/**
 *
 * @author PC
 */
public class App_Promedio_4_Notas_AF {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int num1,num2,num3,num4,prom;
        num1=Integer.parseInt(JOptionPane.showInputDialog("Ingrese nota 1:"));
        num2=Integer.parseInt(JOptionPane.showInputDialog("Ingrese nota 2:"));
        num3=Integer.parseInt(JOptionPane.showInputDialog("Ingrese nota 3:"));
        num4=Integer.parseInt(JOptionPane.showInputDialog("Ingrese nota 4:"));
        prom=((num1+num2+num3+num4)/4);
        JOptionPane.showMessageDialog(null,"El promedio final del estudiante es: "+prom);
    }
    
}
