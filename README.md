# Interview task for Bohdan Roshko
![image](https://user-images.githubusercontent.com/107959377/184979363-b298eeaa-aee6-4e15-b2b5-35718f2567ff.png)
1. Organized db with respect to technical specification above
- Incidents to Accounts relation(1-M)
- Accounts to Contacts relation(1-M)
- IncidentName autogenerated PK string
- AccountName PK(also unique)
2. Introduced Web Api for CRUD operations on db
- account cannot be created without contact
- incident cannot be created without account
- account can be created without an incident
- contact can be created without an account
3. Validation
- if get account request points to non existing record - returns 404
- if contact is in the system - updates contact info
- otherwise - creates new record in db

####PS####
Git commits history is unavailable for this project as I forgot to use source control while developing :(
