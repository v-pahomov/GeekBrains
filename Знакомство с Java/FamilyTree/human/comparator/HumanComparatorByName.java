package FamilyTree.human.comparator;

import FamilyTree.family_tree.FamilyTreeItem;
import FamilyTree.human.Human;

import java.util.Comparator;

public class HumanComparatorByName<E extends FamilyTreeItem> implements Comparator<E> {
    @Override
    public int compare(E o1, E o2) {
        return o1.getName().compareTo(o2.getName());
    }
}
