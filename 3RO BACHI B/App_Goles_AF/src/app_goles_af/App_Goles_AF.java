/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app_goles_af;

import java.util.Scanner;

/**
 *
 * @author UELD-USER-19
 */
public class App_Goles_AF {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Solicitar el marcador del partido
        System.out.println("Ingrese el marcador del Clásico del Astillero:");
        System.out.print("Goles del Barcelona: ");
        int golesBarcelona = scanner.nextInt();
        System.out.print("Goles del Emelec: ");
        int golesEmelec = scanner.nextInt();

        // Determinar el resultado del partido
        String resultado;
        if (golesBarcelona > golesEmelec) {
            resultado = "El Barcelona ganó el Clásico del Astillero.";
        } else if (golesBarcelona < golesEmelec) {
            resultado = "El Emelec ganó el Clásico del Astillero.";
        } else {
            resultado = "El Clásico del Astillero terminó en empate.";
        }

        // Mostrar el resultado del partido
        System.out.println(resultado);

        scanner.close();
    }
    
}
