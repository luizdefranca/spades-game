# spades-game
A simple version of spades game for windows desktop using C#


<h1> Spade-Games Rules </h1>

<h2> Spades for Four Players </h2>

<h2> Players and Cards </h2>

The four players are in fixed partnerships, with partners sitting opposite each other. Deal and play are clockwise.

A standard pack of 52 cards is used. The cards, in each suit, rank from highest to lowest: A, K, Q, J, 10, 9, 8, 7, 6, 5, 4, 3, 2.

<h2> The Deal </h2>

The first dealer is chosen at random, and the turn to deal rotates clockwise. The cards are shuffled and then dealt singly, in clockwise order beginning with the player on dealer's left, until all 52 cards have been dealt and everyone has 13.

<h2> The Bidding </h2>

In Spades, all four players bid a number of tricks. Each team adds together the bids of the two partners, and the total is the number of tricks that team must try to win in order to get a positive score. The bidding begins with the player to dealer's left and continues clockwise around the table. Everyone must bid a number, and in theory any number from 0 to 13 is allowed. Unlike other games with bidding, there is no requirement for each bid to be higher than the last one, and players are not allowed to pass. There is no second round of bidding - bids once made cannot be altered. Example: South deals; West bids 3; North bids 1; East bids 4; South bids 4. The objective of North and South is to win at least 5 ticks (4+1), East and West try to win at least 7 (4+3).

A bid of 0 tricks is known as Nil. This is a declaration that that the player who bid Nil will not win any tricks during the play. There is an extra bonus for this if it succeeds and a penalty if it fails. The partnership also has the objective of winning the number of tricks bid by the Nil's partner. It is not possible to bid no tricks without bidding a Nil. If you don't want to go for the Nil bonus or penalty you must bid at least 1.

Some players allow a bid of Blind nil. This is a nil bid declared before a player looks at his cards. After everyone has bid and before the first lead, the bidder may exchange two cards with partner - the bidder discards two cards face down; partner picks them up and gives back two cards face-down in return. It is usually agreed that Blind Nil may only be bid by a player whose side is losing by at least 100 points.

<h2> The Play of the Hand </h2>

The player to dealer's left leads any card except a spade to the first trick. Each player, in turn, clockwise, must follow suit if able; if unable to follow suit, the player may play any card.

A trick containing a spade is won by the highest spade played; if no spade is played, the trick is won by the highest card of the suit led. The winner of each trick leads to the next. Spades may not be led until either

some player has played a spade (on the lead of another suit, of course), or
the leader has nothing but spades left in hand.
Playing the first spade is known as "breaking" spades.

<h2> Scoring </h2>

A side that takes at least as many tricks as its bid calls for receives a score equal to 10 times its bid. Additional tricks (overtricks) are worth an extra one point each.

Sandbagging rule: Overtricks are colloquially known as bags. A side which (over several deals) accumulates ten or more bags has 100 points deducted from its score. Any bags beyond ten are carried over to the next cycle of ten overtricks - that is if they reached twenty overtricks they would lose another 100 points and so on. (Note: it is not necessary to keep track of overtricks separately as the cumulative number of overtricks taken appears as the final digit of the team's score, if positive).
Example: Suppose a team whose score is 337 bids 5 tricks. If they win 7 tricks they score 52, taking their score to 389. If they win 8 tricks they score 53, but lose 100 because they now have 10 bags, and their score becomes 290 (337 + 53 - 100). If they win 9 tricks they score 54 and lose 100, bringing their score to 291.

If a side does not make its bid, they lose 10 points for each trick they bid.

If a bid of nil is successful, the nil bidder's side receives 100 points. This is in addition to the score won (or lost) by the partner of the nil bidder for tricks made. If a bid of nil fails - that is, the bidder takes at least one trick - the bidder's side loses 100 points, but still receives any amount scored for the partner's bid.

The usual rule is that when a nil fails, the tricks won by the nil bidder do not count towards making the partner's bid, but do count as bags for the team.

A bid of blind nil scores twice as much as an ordinary nil - it wins 200 points if successful and loses 200 points if it fails.

The side which reaches 500 points first wins the game. If both sides reach 500 points in the same deal, the side with the higher score wins.
