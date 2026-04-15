/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package practicanumnp_a;

import java.util.Scanner;

/**
 *
 * @author UELD_USER_25
 */
public class PracticaNumNP_A {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try ( // TODO code application logic here
                Scanner scanner = new Scanner(System.in)) {
            System.out.print("Ingresa un número: ");
            int numero = scanner.nextInt();
            
            determinarPositivoNegativo(numero);
        }
    }

    // Función para determinar si un número es positivo, negativo o cero
    public static void determinarPositivoNegativo(int numero) {
        if (numero > 0) {
            System.out.println("El número ingresado es positivo.");
        } else if (numero < 0) {
            System.out.println("El número ingresado es negativo.");
        } else {
            System.out.println("El número ingresado es cero.");
        }
    }
    
}
