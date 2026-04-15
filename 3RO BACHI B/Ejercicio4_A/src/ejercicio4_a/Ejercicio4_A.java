/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio4_a;

/**
 *
 * @author UELD_USER_25
 */
import javax.swing.JOptionPane;
public class Ejercicio4_A {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        double i1, i2, i3, ti, p1, p2, p3;
        i1=Double.parseDouble(JOptionPane.showInputDialog("Inversionista 1 "));
        i2=Double.parseDouble(JOptionPane.showInputDialog("Inversionista 2 "));
        i3=Double.parseDouble(JOptionPane.showInputDialog("Inversionista 3 "));
        ti=i1+i2+i3;
        p1=(i1*100)/ti;
        p2=(i2*100)/ti;
        p3=(i3*100)/ti;
        JOptionPane.showInputDialog(null,"Total de inversion  "+ti+
                "\n Porcentaje 1=  "+p1+
                "\n Porcentaje 2=  "+p2+
                "\n Porcentaje 3=  "+p3);
    }
    
}
