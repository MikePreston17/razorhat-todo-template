match (user:User)-[likes:LIKES]->(paper:Paper)
return user
, likes
, paper
, count(likes) as occurrence
limit 3
// order by occurrence desc

//match (user:User)-[likes:LIKES]->(paper:Paper)
//return user, likes, paper, count(*) as occurrence
//order by occurrence desc
