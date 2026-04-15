/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package app_mayor_2_num;

/**
 *
 * @author PC
 */
import javax.swing.JOptionPane;
public class App_Mayor_2_Num {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int num1,num2;
        num1=Integer.parseInt(JOptionPane.showInputDialog("Ingrese su primer numero: "));
        num2=Integer.parseInt(JOptionPane.showInputDialog("Ingrese su segundo numero: "));
        if (num1>num2)
            JOptionPane.showMessageDialog(null,"El numero mayor entree los 2 es "+num1);
        else if(num2>num1)
            JOptionPane.showMessageDialog(null,"El numero mayor entree los 2 es "+num2);
    }
    
}
