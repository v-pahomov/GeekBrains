import java.util.*;

class PhoneBook {
    private static HashMap<String, ArrayList<Integer>> phoneBook = new HashMap<>();

    public void add(String name, Integer phoneNum) {
// Введите свое решение ниже
        ArrayList<Integer> phoneNums = phoneBook.getOrDefault(name, new ArrayList<>());
        phoneNums.add(phoneNum);
        phoneBook.put(name, phoneNums);
    }

    public ArrayList<Integer> find(String name) {
// Введите свое решение ниже
        return phoneBook.getOrDefault(name, new ArrayList<>());
    }

    public static HashMap<String, ArrayList<Integer>> getPhoneBook() {
// Введите свое решение ниже
        ArrayList<Map.Entry<String, ArrayList<Integer>>> list = new ArrayList<>(phoneBook.entrySet());
        list.sort((o1, o2) -> o2.getValue().size() - o1.getValue().size());
        for (Map.Entry<String, ArrayList<Integer>> entry : list) {
            System.out.println(entry.getKey() + ": " + entry.getValue());
        }
        return phoneBook;
    }
}

// Не удаляйте этот класс - он нужен для
public class Sem6 {
    public static void main(String[] args) {
        String name1;
        String name2;
        int phone1;
        int phone2;

        if (args.length == 0) {
            name1 = "Ivanov";
            name2 = "Petrov";
            phone1 = 123456;
            phone2 = 654321;
        } else {
            name1 = args[0];
            name2 = args[1];
            phone1 = Integer.parseInt(args[2]);
            phone2 = Integer.parseInt(args[3]);
        }

        PhoneBook myPhoneBook = new PhoneBook();
        myPhoneBook.add(name1, phone1);
        myPhoneBook.add(name1, phone2);
        myPhoneBook.add(name2, phone2);
        myPhoneBook.add("Pahomov", 93137790);
        myPhoneBook.add("Pahomov", 12345654);
        myPhoneBook.add("Pahomov", 34832748);
        myPhoneBook.add("Petrov", 34832748);
        myPhoneBook.add("Petrov", 34832748);
        myPhoneBook.add("Petrov", 34832748);

        PhoneBook.getPhoneBook();
    }
}