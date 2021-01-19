import java.io.IOException;
import java.util.Scanner;


public class ProblemasBasicos{
    public static void main(String[] args) throws IOException {
      Scanner input = new Scanner(System.in);
      int total = Integer.parseInt(input.next());
    	for (int i = 2 ; i <=total  ; i++) {
    		if (i%2==0 ) System.out.println(i);
    	}
    }
	
}