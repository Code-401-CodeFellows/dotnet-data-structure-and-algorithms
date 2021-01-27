using DataStructures;
using Xunit;

namespace CodeChallengeTests
{
    public class CodeChallengeUnitTest
    {
        /// <summary>
        /// If the returned Node is the proper Head, indicating a properly zipped Linked List
        /// </summary>
        [Fact]
        public void Zipped_Linked_List_Returns_Expected_Head_Node()
        {
            LinkedList aList = new LinkedList();
            aList.Insert(10);
            aList.Insert(8);
            aList.Insert(6);
            aList.Insert(4);
            aList.Insert(2);
            LinkedList bList = new LinkedList();
            bList.Insert(9);
            bList.Insert(7);
            bList.Insert(5);
            bList.Insert(3);
            bList.Insert(1);
            Assert.Equal(9, DataStructures.Program.ZipLists(aList, bList).Value);
        }
        [Fact]
        public void Zipped_Linked_List_Does_Not_Return_A_Previous_Node()
        {
            LinkedList aList = new LinkedList();
            aList.Insert(10);
            aList.Insert(8);
            aList.Insert(6);
            aList.Insert(4);
            aList.Insert(2);
            LinkedList bList = new LinkedList();
            bList.Insert(9);
            bList.Insert(7);
            bList.Insert(5);
            bList.Insert(3);
            bList.Insert(1);
            Assert.NotEqual(10, DataStructures.Program.ZipLists(aList, bList).Value);
        }
        [Fact]
        public void Psuedo_Queue_Test_Enqueue_Int()
        {
            QueueWithStacks testQueue = new QueueWithStacks();
            testQueue.stack1.Push(5);
            testQueue.stack1.Push(10);
            testQueue.stack1.Push(15);
            testQueue.stack1.Push(20);
            testQueue.stack1.Push(25);
            testQueue.Enqueue(30);
            Assert.Equal(30, testQueue.stack1.Top.Value);
        }
        [Fact]
        public void Psuedo_Queue_Test_Dequeue_Int()
        {
            QueueWithStacks testQueue = new QueueWithStacks();
            testQueue.stack1.Push(5);
            testQueue.stack1.Push(10);
            testQueue.stack1.Push(15);
            testQueue.stack1.Push(20);
            testQueue.stack1.Push(25);

            Assert.Equal(10, testQueue.Dequeue());
        }
        [Fact]
        public void Psuedo_Queue_Dequeue_Empty()
        {
            QueueWithStacks testQueue = new QueueWithStacks();
            Assert.Equal(-1, testQueue.Dequeue());
        }

        [Fact]
        public void Animal_Shelter_Enqueue()
        {
            AnimalShelter testShelter = new AnimalShelter();
            testShelter.Enqueue(new Cat());
            testShelter.Enqueue(new Cat());
            testShelter.Enqueue(new Cat());
            testShelter.Enqueue(new Dog());

            Assert.Equal("Dog", testShelter.Rear.Species);
        }
        [Fact]
        public void Animal_Shelter_Dequeue_To_Pref()
        {
            AnimalShelter testShelter = new AnimalShelter();
            testShelter.Enqueue(new Cat());
            testShelter.Enqueue(new Cat());
            testShelter.Enqueue(new Dog());
            testShelter.Enqueue(new Cat());

            Assert.IsType<Dog>(testShelter.Dequeue("Dog"));

        }
    }
}
