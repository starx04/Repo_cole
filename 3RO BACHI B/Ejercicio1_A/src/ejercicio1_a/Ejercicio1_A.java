/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio1_a;

/**
 *
 * @author UELD_USER_25
 */
import javax.swing.JOptionPane;
public class Ejercicio1_A {
    public static void main(String[] args) {
        // TODO code application logic here
        int pn,sn,su,re,mu,di;
        pn=Integer.parseInt(JOptionPane.showInputDialog("Primer numero"));
        sn=Integer.parseInt(JOptionPane.showInputDialog("Segundo numero"));
        su=pn+sn;
        re=pn-sn;
        mu=pn*sn;
        di=pn/sn;
        JOptionPane.showInputDialog(null,"La suma es    "+su+
                "\n La resta es    "+re+
                "\n La multiplicacion es    "+mu+
                "\n La division es    "+di);
    }
    
}
