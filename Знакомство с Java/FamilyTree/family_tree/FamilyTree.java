package FamilyTree.family_tree;

import FamilyTree.human.Human;
import FamilyTree.human.comparator.HumanComparatorByAge;
import FamilyTree.human.comparator.HumanComparatorByName;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class FamilyTree<T extends TreeNode<T> & FamilyTreeItem> implements Iterable<T>, Serializable {
    private long humansId;
    private List<T> humanList;

    public FamilyTree() {
        this(new ArrayList<>());
    }

    public FamilyTree(List<T> humanList) {
        this.humanList = humanList;
    }

    public boolean add(T human) {
        if (human == null) {
            return false;
        }
        if (!humanList.contains(human)) {
            humanList.add(human);
            human.setId(humansId++);

            addToParents(human);
            addToChildren(human);
            return true;
        }
        return false;
    }

    private void addToChildren(T human) {
        for (T child : human.getChildren()) {
            child.addParent(human);
        }
    }

    private void addToParents(T human) {
        for (T parent : human.getParents()) {
            parent.addChild(human);
        }
    }

    public boolean setWedding(T human1, T human2) {
        if (human1.getSpouse() == null && human2.getSpouse() == null) {
            human1.setSpouse(human2);
            human2.setSpouse(human1);
            return true;
        } else {
            return false;
        }
    }

    public void setParentAndChild(T mother, T father, T child) {
        mother.addChild(child);
        father.addChild(child);
        child.addParent(mother);
        child.addParent(father);
        add(child);
    }

    @Override
    public String toString() {
        return getInfo();
    }

    public String getInfo() {
        StringBuilder sb = new StringBuilder();
        sb.append("В дереве ");
        sb.append(humanList.size());
        sb.append(" объектов: \n");
        for (T human : humanList) {
            sb.append(human);
            sb.append("\n");
        }
        return sb.toString();
    }
    
    public T getByName(String name) {
        T hum = null;
        for (T human: humanList) {
            if(human.getName().equals(name)){
                hum = human;
            }
        }
        return hum;
    }

    public T getByID (long id) {
        T hum = null;
        for (T human: humanList) {
            if(human.getId() == id){
                hum = human;
            }
        }
        return hum;
    }
    public T removeFromTree(T human) {
        T removeHuman = humanList.get((int) human.getId());
        humanList.remove(human);
        return removeHuman;
    }

    public List<T> getHumanList() {
        return humanList;
    }

    public void sortByName(){
        humanList.sort(new HumanComparatorByName<>());
    }

    public void sortByAge(){
        humanList.sort(new HumanComparatorByAge<>());
    }

    @Override
    public Iterator<T> iterator() {
        return new FamilyTreeIterator<>(humanList);
    }
}
