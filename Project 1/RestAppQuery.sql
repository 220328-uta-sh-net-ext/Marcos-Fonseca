
CREATE TABLE Restaurant (
    RestId INT IDENTITY NOT NULL,
    RestName  VARCHAR(150) NOT NULL,
    RestCity VARCHAR(150),
    RestState VARCHAR(150),
    RestPhone VARCHAR(20) NOT NULL,
    PRIMARY KEY (RestId)
    );

CREATE TABLE Login (
    UserId INT IDENTITY NOT NULL,
    Login  VARCHAR(150) NOT NULL,
    FirstName VARCHAR(150) NOT NULL,
    LastName VARCHAR(150) NOT NULL,
    Email VARCHAR (150) NOT NULL,
    PASSWORD VARCHAR(150) NOT NULL,
    PRIMARY KEY (UserId)
   );


CREATE TABLE Review (
    ReviewId INT IDENTITY NOT NULL,
    UserId  INT NOT NULL,
    RestId INT NOT NULL,
    Score INT NOT NULL,
    Comment VARCHAR(250),
    PRIMARY KEY (ReviewId),
    FOREIGN KEY (UserId) REFERENCES Login (UserId),
    FOREIGN KEY (RestId) REFERENCES Restaurant(RestId)
   );


INSERT INTO Restaurant (RestName, RestCity, RestState, RestPhone) VALUES
('Brazilian BBQ', 'New York', 'NY', '123456789'),
('TexMex', 'New York', 'NY', '3213456789'),
('Dallas BBQ', 'New York', 'NY', '456456789'),
('TacoLoko', 'Enrico', 'VA', '654456789');
('Kingston Tropical', 'New York', 'NY', '7187980076'),
('Africa Kine', 'New York', 'NY', '2126669400'),
('Hudson Smokehouse', 'New York', 'NY', '7188727742'),
('Mariscos El Submarino', 'New York', 'NY', '7186852780'),
('Golden Palace', 'New York', 'NY', '7188864383'),
('Birria-Landia', 'New York', 'NY', '3472832162'),
('Nepali Bhanchha Ghar', 'New York', 'NY', '9177450533'),
('Playground', 'New York', 'NY', '7187797912'),
('Jua', 'New York', 'NY', '6465901598'),
('Aarzu', 'Jersey City', 'NJ', '7323330933'),
('Battello', 'Jersey City', 'NJ', '2017981798'),
('Cellar 335', 'Jersey City', 'NJ', '2012221422'),
('Chez Catherine', 'Jersey City', 'NJ', '9086544011'),
('The Circle', 'Jersey City', 'NJ', '9086544011'),
('Elements', 'Jersey City', 'NJ', '6099240078'),
('Fascino', 'Jersey City', 'NJ', '9732330350');
('LT Bar & Grill', 'New York', 'NY', '5512876333');


INSERT INTO Review (RestId, Score, Comment) VALUES
('1', '4', 'This cozy restaurant'),
('1', '5', 'You have to go!'),
('1', '4', 'It’s a great experience'),
('2', '5', 'Visit this lovely restaurant'),
('2', '5', 'I enjoyed every single bite'),
('2', '5', 'Excellent food.'),
('2', '5', 'My absolute favorite restaurant'),
('2', '5', 'This place is great!'),
('3', '3', 'So far so good'),
('3', '2', 'My meal was cold'),
('3', '2', 'It took 30 minutes to be served!'),
('3', '1', 'My food came raw!');

INSERT INTO Restaurant (RestName, RestCity, RestState, RestPhone) VALUES
    ('LT Bar & Grill', 'New York', 'NY', '5512876333');

select * from Review
    select Top 50 * from Restaurant
    where Restname like '%a%'

SELECT a.RestName AS RESTAURANT, AVG(b.Score) as AVG FROM Review b
INNER JOIN Restaurant a ON a.RestId = b.RestId
GROUP BY b.RestId,a.RestName
ORDER BY AVG DESC


select * 
from Login