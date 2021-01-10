Console Application<br/>
Exercise: Associative Arrays<br/><br/>

# LegendaryFarming
You’ve done all the work and the last thing left to accomplish is to own a __legendary__ item. However, it’s a tedious process and it requires quite a bit of farming. Anyway, you are not too pretentious - any legendary item will do. The possible __items__ are:
* __Shadowmourne__ - requires __250 Shards__;
* __Valanyr__ - requires __250 Fragments__;
* __Dragonwrath__ - requires __250 Motes__;
__Shards, Fragments__ and __Motes__ are the __key materials__ and everything else is __junk__. You will be given lines of input, in the format:<br/>
2 motes 3 ores 15 stones<br/>
Keep track of the __key materials__ - the __first__ one that reaches the __250 mark__, __wins__ the race. At that point you have to print that the corresponding legendary item is obtained. Then, print the __remaining__ shards, fragments, motes, ordered by __quantity__ in __descending__ order, then by __name__ in __ascending__ order, each on a new line. Finally, print the collected __junk__ items in __alphabetical__ order.
## Input
* Each line comes in the following format: __{quantity} {material} {quantity} {material} … {quantity} {material}__
## Output
* On the first line, print the obtained item in the format: __{Legendary item} obtained!__
* On the next three lines, print the remaining key materials in __descending order by quantity__
  * If __two__ key materials have the same quantity, print them in __alphabetical order__
* On the final several lines, print the __junk__ items in __alphabetical order__
  * All materials are printed in format __{material}: {quantity}__
  * The output should be __lowercase__, except for the first letter of the legendary
## Examples
Input | Output
------|-------
3 Motes 5 stones 5 Shards<br/>6 leathers 255 fragments 7 Shards| Valanyr obtained!<br/>fragments: 5<br/>shards: 5<br/>motes: 3<br/>leathers: 6<br/>stones: 5
123 silver 6 shards 8 shards 5 motes<br/>9 fangs 75 motes 103 MOTES 8 Shards<br/>86 Motes 7 stones 19 silver|Dragonwrath obtained<br/>shards: 22<br/>motes: 19<br/>fragments: 0<br/> fangs: 9<br/>silver: 123
