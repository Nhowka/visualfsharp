// #Conformance #DataExpressions #Query
// DevDiv:179889, groupValBy was hard to use with poor diagnostics
//<Expects status="error" span="(8,9-8,28)" id="FS0001">This expression was expected to have type.    'Linq\.QuerySource\<'a,'b\> \* \('a \-\> 'c\) \* \('a \-\> 'd\)'    .but here has type.    'Linq\.QuerySource\<int,System\.Collections\.IEnumerable\>'</Expects>
//<Expects status="error" span="(15,9-15,19)" id="FS3099">'groupValBy' is used with an incorrect number of arguments\. This is a custom operation in this query or computation expression\. Expected 2 argument\(s\), but given 1\.$</Expects>	//<Expects status="error" span="(15,9-15,21)" id="FS0501">The member or object constructor 'GroupValBy' takes 3 argument\(s\) but is here given 2\. The required signature is 'member Linq\.QueryBuilder\.GroupValBy \: source\:Linq\.QuerySource\<'T,'Q\> \* resultSelector\:\('T \-\> 'Value\) \* keySelector\:\('T \-\> 'Key\) \-\> Linq\.QuerySource\<System\.Linq\.IGrouping\<'Key,'Value\>,'Q\> when 'Key \: equality'\.$</Expects>

let q1 = 
    query {
        for c in [1..10] do
        groupValBy         
    }

let q2 =
    query {
        for c in [1..10] do
        groupValBy c        
    }

let q3 = // no error
    query {
        for c in [1..10] do
        groupValBy c c
    }

exit 1
