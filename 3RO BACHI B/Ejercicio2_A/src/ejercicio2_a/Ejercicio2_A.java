/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio2_a;

/**
 *
 * @author UELD_USER_25
 */
import javax.swing.JOptionPane;
public class Ejercicio2_A {
    public static void main(String[] args){
        String nom;
        nom=JOptionPane.showInputDialog("Nombre del producto ");
        double pre,can,st,iva,tp;
        pre=Integer.parseInt(JOptionPane.showInputDialog("Ingresa el precio"));
        can=Integer.parseInt(JOptionPane.showInputDialog("Ingresa la cantidad"));
        st=pre*can;
        iva=st*0.12;
        tp=st+iva;
        JOptionPane.showInputDialog(null,"El subtotal es  "+st+
                "\n El iva es  "+iva+
                "\n El total a pagar es  "+tp);
        // TODO code application logic here
    }
    
}
