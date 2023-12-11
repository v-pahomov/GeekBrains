package FamilyTree;

import FamilyTree.family_tree.FamilyTree;
import FamilyTree.family_tree.FamilyTreeIterator;
import FamilyTree.human.Gender;
import FamilyTree.human.Human;
import FamilyTree.writer.FileHandler;
import java.time.LocalDate;

public class Main {
    public static void main(String[] args){
        FamilyTree<Human> tree = testTree();
        save(tree);
        tree = load();
        FamilyTreeIterator<Human> iterator = new FamilyTreeIterator<>(tree.getHumanList());
        while (iterator.hasNext()){
            System.out.println(iterator.next());
        }
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
        static FamilyTree<Human> testTree() {
        FamilyTree<Human> tree = new FamilyTree<>();

        Human vasya = new Human("Василий", Gender.Male, LocalDate.of(1963, 12, 10));
        Human masha = new Human("Мария", Gender.Female, LocalDate.of(1965, 9, 15));
        tree.add(vasya);
        tree.add(masha);
        tree.setWedding(vasya, masha);

        Human cristina = new Human("Кристина", Gender.Female, LocalDate.of(1988, 7, 5), masha, vasya);
        Human semen = new Human("Семен", Gender.Male, LocalDate.of(1991, 1, 25), masha, vasya);
        tree.add(cristina);
        tree.add(semen);
        Human grandmother = new Human("Петр", Gender.Male, LocalDate.of(1935, 3, 5));
        Human grandfather = new Human("Надежда", Gender.Female, LocalDate.of(1935, 6, 8));
        tree.add(grandfather);
        tree.add(grandmother);
        tree.setParentAndChild(grandmother, grandfather, masha);
        return tree;
    }
}
