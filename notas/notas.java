import java.io.IOException;
import java.util.Scanner;
public class Notas{
	
    public static void main(String[] args) throws IOException {
      Scanner input = new Scanner(System.in);
      int nota = input.nextInt();
      //int range = (nota<1)?0:(1<= nota && nota <= 35)?1:(36<= nota && nota <= 60)?2:(61<= nota && nota <= 85)?3:4;
      if (nota==0){
        System.out.println('E');
      } else if(1<= nota && nota <= 35){
        System.out.println('D');
      }else if (36<= nota && nota <= 60){
        System.out.println('C');
      }else if (61<= nota && nota <= 85){
        System.out.println('B');
      }else if (86<= nota && nota <= 100){
        System.out.println('A');
      }
      
    }
	
}