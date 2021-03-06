# BookStore
Project Example for KPMG interview. 
WebApi architecture based on a Clean Architecture approach proposed by Jason Taylor in his presentation and template on GOTO Copenhagen 2019 
https://www.youtube.com/watch?v=dK4Yb6-LxAk&amp;feature=youtu.be&amp;list=LLzkOSY7CrOPzEEKCg3HJqqA

text below https://files.gotocon.com/uploads/slides/conference_15/984/original/2019GotoCphCleanArchitectureByJasonTaylor.pdf


#Clean Architecture:
- Indendent of frameworks
- Testable
- Independent of UI
- Independent of database
- Independent of anything external.

#Demo layers
- Domain: Contains enterprise-wide logic and types -> core
- Application : contains business-logic and types -> core
- Infrastructure: contains all external concers
- Presentation and Infrastructure depend only on Application
- Presentation and Infrastructure components can be replasable with minimal effort.

#Domain:
- avoid using data annotations
- Use value objects when appropiated
- Create custom domain exceptions

#Application
- Uses command and Query Responsability Segregation(CQRS)+ MediatR  which simplifies the overall design
- MediatR simplifies cross cutting concerns
- Fluent Validation is useful for all validations scenarios 
- Automapper simplifies mapping and projections

#Infrastructure
- Independent of the database
- Use fluent API configuration over data annotation
- Prefer convwentions over configurations
- Automatically apply all entity type configurations
- no layer depends on Infrastructure layer

#Presentation
- Controllers should not contain any application logic
- Create and consume well define view models

