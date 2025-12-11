using POC_Xunit_Project.Add;
using POC_Xunit_Project.Division;
using POC_Xunit_Project.Multiplication;
using POC_Xunit_Project.Operations;
using POC_Xunit_Project.Substraction;

static void main()
{

    Operation ob = new Operation(new Addd(), new Divisions(), new Multiplications(), new Substractions()) ;
    List<int> intList = new List<int>();
    intList = ob.CalculateMultipleOperations(2, 3, 4);

    int addition = ob.DoContinuousAddition(intList);

    int count = ob.FindCountOfTheStorage(intList);
    int safechek = ob.SafeCheck(addition, count);



}
main();