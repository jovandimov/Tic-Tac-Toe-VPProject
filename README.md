**Tic-Tac-Toe**

Опис на апликацијата

Апликацијата Tic-Tac-Toe е класична игра наменета за двајца играчи кои наизменично внесуваат потези во прикажаната табла, која може да биде со различна големина. Во играта едниот играч внесува X додека другиот внесува О. На слика.1 ни е претставена почетната страна на играта. На почетната страна имаме опција Play Game со која ја започнувате играта и се прикажува прозорецот прикажан на слика.2. Доколку се избере опцијата Exit Game апликацијата се гаси.
 
 <img align="center" width="448" alt="1" src="https://user-images.githubusercontent.com/85314744/121818221-20a06a80-cc86-11eb-8ce7-d10e8b4f2aa8.png">  <img align="center" width="308" alt="2" src="https://user-images.githubusercontent.com/85314744/121818274-6b21e700-cc86-11eb-94fb-206a6e8f52db.png">
 
 слика.1 -                                                                                                                                              слика.2


 
 
 Откако ќе ни се прикаже прозорецот прикажан на слика.2 потребно е да се внесат имињата на играчите, а дополнително секој играч има опција да си избере боја со која ќе биде прикажан. Се селектира број на победени партии за победа на целата игра (минимално е една победа).  Овие карактеристики ни се чуваат како својства во GameOptions. Играта ни нуди можност да одбереме димензија на табла кои може да бидат од 3x3 до 10x10, па ни се отвора форма со исцртана табла со соодветно избраната големина. Тука ни станува збор за класата MultiDimensional чиј конструктор ја прима големината на таблата.
На слика.3 ни е прикажан прозорецот на кој се внесени сите податоци и оттука доколку избереме Play Game играта започнува(слика.5).
Доколку некој играч не внесе име во зададеното поле апликацијата не дозволува да се пополнат другите полиња, а со тоа не може ни да се започне играта – имплементирано со валидација ("**The name is required!**").  слика.4

<img width="307" alt="3" src="https://user-images.githubusercontent.com/85314744/121818395-3c584080-cc87-11eb-86ed-cc0ecd177393.png"> <img width="401" alt="4" src="https://user-images.githubusercontent.com/85314744/121818402-411cf480-cc87-11eb-8555-84519d6811bb.png">

слика.3 - слика.4

Играта започнува со тоа што првиот потег го има player1 чие преостанато време е прикажано со Progress bar и доколку му заврши времето,а не одбрал потег тој добива -1 поен од досегашните (соодветно и за другиот играч).

<img width="581" alt="5" src="https://user-images.githubusercontent.com/85314744/121818421-60b41d00-cc87-11eb-9604-98090f89e425.png">

слика.5
 
 
 За да биде избран победник на партијата потребно е играчот да има внесено **три последователни потези хоризонтално, вертикално или дијагонално**, со што истиот добива +1 поен. На слика.6 ни е прикажан прозорецот кој најавува победа на играчот што победил. Но доколку сите полиња се пополнат, а нема победа од ниту еден играч, тогаш имаме нерешен резултат односно tie.  Во оваа ситуација ниту еден од играчите не добива поени ниту пак губи поени.(слика.7) За секој играч поените кој до сега ги добил се прикажуваат под Progress bar-от.
 
 <img width="580" alt="6" src="https://user-images.githubusercontent.com/85314744/121818441-7e818200-cc87-11eb-9b43-7a15aa6c7e61.png"> <img width="582" alt="7" src="https://user-images.githubusercontent.com/85314744/121818457-8b9e7100-cc87-11eb-8507-5f0aec6fb9a1.png">

 слика.6 - слика.7 
 
 На слика.8 ни е прикажана играта доколку внесеме димензија на таблата да ни биде 5x5.
 
 <img width="578" alt="8" src="https://user-images.githubusercontent.com/85314744/121818485-b7215b80-cc87-11eb-8165-85e6e23c8219.png">

слика.8
  
 
 **Имплементација**
 
Играта Tic-Tac-Toe е имплементирана така што се генерираат копчиња во вид на матрица според избраната димензија на табла, секој потег (X или О) ни е всушност клик на копче, на кое се испишува X/O. Во матрицата соодветно се пополнуваат вредности 1 или 0, 1 за потег X, 0 за потег O. За секој вид на табла важи истиот начин на победување како што е за 3x3 класичната табла (хоризонтално, вертикално или дијагонално).

Првиот играч секогаш започнува со X, а секој играч има време од 15 секунди за да одбере поле. Истекувањето на времето е прикажано со **Progress bar**. 
За секој потег се испишува кој играч е на ред, неговото преостанато време и неговиот број на поени. 

Со помош на матрицата од единици и нули, во функцијата **checkWin** се прават проверки за победа на партијата.

Функцијата **checkDraw** проверува дали се пополнети сите копчиња, односно дали бројот на потези е еднаков со бројот на копчиња а воедно и  сеуште нема победник во партијата. Доколку е тоа исполнето имаме нерешена партија-tie.

Функцијата **checkTimer** го проверува преостанатато време на играчите.

За секоја партија имаме опција **ResetGame** која пребришува се за тековната, додека се друго за досегашната состојба на играта останува исто. Односно правиме reset на партијата, не на целата игра.

 
