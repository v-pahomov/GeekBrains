package FamilyTree;

import FamilyTree.family_tree.FamilyTree;
import FamilyTree.human.Gender;
import FamilyTree.human.Human;
import FamilyTree.writer.FileHandler;
import java.time.LocalDate;

public class Main {
    public static void main(String[] args){
        FamilyTree tree = testTree();
        System.out.println(tree);
        save(tree);

        FamilyTree tree1 = load();
        Human grandFather = new Human("Петр", Gender.Male, LocalDate.of(1937, 3, 5));
        grandFather.addChild(tree1.getByName("Мария"));
        tree1.getByName("Мария").addParent(grandFather);
        tree1.add(grandFather);
        System.out.println(tree1);
    }

    public static FamilyTree load(){
        String filePath = "writer/tree.txt";
        FileHandler fileHandler = new FileHandler();
        return (FamilyTree) fileHandler.read(filePath);
    }

    public static void save(FamilyTree tree){
        String filePath = "writer/tree.txt";
        FileHandler fileHandler = new FileHandler();
        fileHandler.save(tree, filePath);
    }
    static FamilyTree testTree() {
        FamilyTree tree = new FamilyTree();

        Human vasya = new Human("Василий", Gender.Male, LocalDate.of(1963, 12, 10));
        Human masha = new Human("Мария", Gender.Female, LocalDate.of(1965, 9, 15));
        tree.add(vasya);
        tree.add(masha);
        tree.setWedding(vasya, masha);

        Human cristina = new Human("Кристина", Gender.Female, LocalDate.of(1988, 7, 5), vasya, masha);
        Human semen = new Human("Семен", Gender.Male, LocalDate.of(1991, 1, 25), vasya, masha);
        tree.add(cristina);
        tree.add(semen);
        return tree;
    }
}
