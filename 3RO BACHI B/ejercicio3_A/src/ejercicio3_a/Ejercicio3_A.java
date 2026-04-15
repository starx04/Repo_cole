/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio3_a;

/**
 *
 * @author UELD_USER_25
 */
import javax.swing.*;
public class Ejercicio3_A {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        double ht,sn,des,sr;
        ht=Double.parseDouble(JOptionPane.showInputDialog("Horas trabajadas"));
        sn=ht*3;
        des=sn*9.35/100;
        sr=sn-des;
        JOptionPane.showInputDialog(null,"\n El salario Neto  "+sn+
                "\n Descuento  "+des+
                "\n Salario a recibir  "+sr);
    }
    
}
