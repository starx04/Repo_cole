/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app_votacion_af;

import javax.swing.JOptionPane;

/**
 *
 * @author PC
 */
public class App_Votacion_AF {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int eda;
        eda=Integer.parseInt(JOptionPane.showInputDialog("Ingrese su edad:"));
        if(eda>16)
            JOptionPane.showMessageDialog(null,"Si puede sufragar en las elecciones de 2024");
        else if (eda<16)
            JOptionPane.showMessageDialog(null,"No puede sufragar en las elecciones de 2024");
    }
    
}
