// var helper = new PagnationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);
// Console.WriteLine(helper.PageCount); //should == 2
// Console.WriteLine(helper.ItemCount); //should == 6
// Console.WriteLine(helper.PageItemCount(0)); //should == 4
// Console.WriteLine(helper.PageItemCount(1)); // last page - should == 2
// Console.WriteLine(helper.PageItemCount(2)); // should == -1 since the page is invalid


// Console.WriteLine(helper.PageIndex(5)); //should == 1 (zero based index)
// Console.WriteLine(helper.PageIndex(2)); //should == 0
// Console.WriteLine(helper.PageIndex(20)); //should == -1
// Console.WriteLine(helper.PageIndex(-10)); //should == -1

var text2 = TopWords.Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e");

foreach (var item in text2)
{
    Console.WriteLine(item);
}

