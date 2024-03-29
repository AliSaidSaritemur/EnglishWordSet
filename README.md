<h2 align="center">EnglishWordSet</h2>
To improve their English skills, it randomly asks for the English words that the user has added, and then together with a sentence using these words
Expressions of these words after saving and It is a project where you can see images about words.


<h3 align="center">APIs used</h3>
<ul>
  <li>Google Translate API for translation</li>
  <li> Unsplash API for getting image about the words </li>
  <li> Rapid API for getting sentece </li>
  <li> Heroku API for getting random word</li>
  <li> Datamuse API for getting the word frequency </li>
</ul>
  

<h3 align="center">Nuget Packages used</h3>
<ul>
  <li>Entity Framework</li>
  <li>Nlog </li>
  <li> Tulpep </li>
</ul>


<h3 align="center">UI</h3>

<h5>On this page, the user can add the words he has chosen to the DB. In addition, the user can choose from the given word types and add words through the API.
After each random word brought, the token amount decreases by one and the token amount of each user is renewed every day.
And words containing characters such as sign numbers (?drawer 1) are thrown into the recycle bin.</h5>
<p align="center">
<img src="UIPics\UserUI.jpg" width="400"  ></p>
<h5>One of the words added to the DB on the previous page is randomly asked to the user.
In addition, words are added to the text and each time you write the meaning, the counter next to the words increases.</h5>
<p align="center">
<img src="UIPics\EnglishWordsetUI.jpg" width="400"  ></p>
In cases where the user does not know the word, he can save the word, a sentence in which the word is used and its meaning in the system from this page. 
In addition, if he presses the new button,the sentences come through the API randomly, if the meaning of the word is not filled, the system performs it via the API.
<p align="center">
<img src="UIPics\LearnedWordUI.jpg" width="400"   ></p>

<h5>When the user does not remember the meaning of the word in the coming days, he can see the sentence he has saved before on this page. 
However, if he does not remember the meaning of the word, he is provided to remember it through the pictures taken over the API.</h5>
<p align="center">
<img src="UIPics\SearchedPAge.jpg" width="400"  ></p>

<h2 align="center">Games</h2>


<h3 align="center">Last Letter Game </h3>

<h5>In this game, we generate a new word from the last letter of the word we wrote. For example, after "pencil," the requested letter will be "L," and a word starting with the letter "L" should be written. Additionally, there is a time limit of 60 seconds in the game, and an additional 3 seconds are added with each word entered. The words are checked, and words with a frequency close to 0 are not approved. Apart from these, each user's best scores are saved.</h5>
<p align="center">
<img src="UIPics\LastLetterGame.png" width="400"  ></p>

<h3 align="center">Create Sentence Game </h3>

<h5>In this game, four words randomly appear from the user's previously learned words, and the user is asked to create meaningful sentences using these words. If the user doesn't remember a word, they can open the "Learned Word" panel. Additionally, they can click the "Test" button to check the meaning of the sentence they wrote.</h5>
<p align="center">
<img src="UIPics\CreateSentenceGame.png" width="400"  ></p>

