import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
public class AAA {
    public static void main(String[] args) {
        var aa=Arrays.asList(1,2,4,1,5,3,2,5,4,8,9,1,4);
        aa.stream().filter(x->x>=2&&x<=5).sorted().forEach(System.out::println);

    }
}