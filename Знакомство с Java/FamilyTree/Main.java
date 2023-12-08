package FamilyTree;

import FamilyTree.family_tree.FamilyTree;
import FamilyTree.human.Gender;
import FamilyTree.human.Human;
import FamilyTree.writer.FileHandler;
import java.time.LocalDate;

public class Main {
    public static void main(String[] args){
        FamilyTree tree1 = load();
        System.out.println(tree1);
        tree1.sortByAge();
        System.out.println(tree1);
        tree1.sortByName();
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
