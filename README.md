# Challenge proposed by ABM Data Systems, which contains 3 questions:
:vertical_traffic_light: The project is dot net core 3.0 :vertical_traffic_light:
### :thumbsup: Developer Technical Questions.

1. [ ] Taking the following EDIFACT message text, write some code to parse out the all the LOC segments and populate an array with the 2nd and 3rd element of each segment.
Note: the ‘+’ is an element delimiter

```
UNA:+.? '
UNB+UNOC:3+2021000969+4441963198+180525:1225+3VAL2MJV6EH9IX+KMSV7HMD+CUSDECU-IE++1++1'
UNH+EDIFACT+CUSDEC:D:96B:UN:145050'
BGM+ZEM:::EX+09SEE7JPUV5HC06IC6+Z'
LOC+17+IT044100'
LOC+18+SOL'
LOC+35+SE'
LOC+36+TZ'
LOC+116+SE003033'
DTM+9:20090527:102'
DTM+268:20090626:102'
DTM+182:20090527:102'
```

2. [ ] Taking the following XML document, write code to extract the RefText values for the following RefCodes: ‘MWB’, ‘TRV’ and ‘CAR’

```XML
<?xml version="1.0" encoding="UTF-8"?>
<InputDocument>
   <DeclarationList>
      <Declaration Command="DEFAULT" Version="5.13">
         <DeclarationHeader>
            <Jurisdiction>IE</Jurisdiction>
            <CWProcedure>IMPORT</CWProcedure>
            <DeclarationDestination>CUSTOMSWAREIE</DeclarationDestination>
            <DocumentRef>71Q0019681</DocumentRef>
            <SiteID>DUB</SiteID>
            <AccountCode>G0779837</AccountCode>
            <Reference RefCode="MWB">
               <RefText>586133622</RefText>
            </Reference>
            <Reference RefCode="KEY">
               <RefText>DUB16049</RefText>
            </Reference>
            <Reference RefCode="CAR">
               <RefText>71Q0019681</RefText>
            </Reference>
            <Reference RefCode="COM">
               <RefText>71Q0019681</RefText>
            </Reference>
            <Reference RefCode="SRC">
               <RefText>ECUS</RefText>
            </Reference>
            <Reference RefCode="TRV">
               <RefText>1</RefText>
            </Reference>
            <Reference RefCode="CAS">
               <RefText>586133622</RefText>
            </Reference>
            <Reference RefCode="HWB">
               <RefText>586133622</RefText>
            </Reference>
            <Reference RefCode="UCR">
               <RefText>586133622</RefText>
            </Reference>
            <Country CodeType="NUM" CountryType="Destination">IE</Country>
            <Country CodeType="NUM" CountryType="Dispatch">CN</Country>
         </DeclarationHeader>
      </Declaration>
   </DeclarationList>
</InputDocument>
```

3. [x] Write a webservice that accepts the following XML document as the payload:

```XML
<?xml version="1.0" encoding="UTF-8"?>
<InputDocument>
   <DeclarationList>
      <Declaration Command="DEFAULT" Version="5.13">
         <DeclarationHeader>
            <Jurisdiction>IE</Jurisdiction>
            <CWProcedure>IMPORT</CWProcedure>
            <DeclarationDestination>CUSTOMSWAREIE</DeclarationDestination>
            <DocumentRef>71Q0019681</DocumentRef>
            <SiteID>DUB</SiteID>
            <AccountCode>G0779837</AccountCode>
         </DeclarationHeader>
      </Declaration>
   </DeclarationList>
</InputDocument>
```

The webservice should respond with a status code which is based on parsing the contents of the XML payload.
- If the XML document is given here is passed then return a status of ‘0’ – which means the document was structured correctly.
- If the Declararation’s Command <> ‘DEFAULT’ then return ‘-1’ – which means invalid command specified.
- If the SiteID <> ‘DUB’ then return ‘-2’ – invalid Site specified.

*****
### Solution implemented :thumbsup:
**Software modeling approach was developed the challenge "DDD Architecture", Domain Driven Design (DDD).** Reference [Eric Ferreira](https://medium.com/@ericandrade_24404/parte-01-criando-arquitetura-em-camadas-com-ddd-injeção-de-dep-ef-60b851c88461).
>DDD is a software modeling approach that follows a set of practices to facilitate the implementation of complex business rules / processes that we treat as a domain. - Eduardo Pires

- 02 - Services: receives “Application” reference.
- 03 - Application: receives "Domain" reference.
- 04 - Domain: Although it is the layer that most supports the other layers, it is the only one that receives no reference from anyone, so it depends on nothing! However, as the image shows, it communicates “indirectly” with the Data (Infrastructure) layer, and this is only possible thanks to interfaces.
- 05 - Infrastructure: Last but not least, we have this layer that (as previously mentioned) has “sublayers” Data and CrossCutting, where they receive domain reference.
Data: is intended to persist data or any other external communication.
CrossCurring (Ioc): This is where all the interfaces and classes in the project are registered, so that it is responsible for instantiating the dependency tree of the whole architecture.

*A note on architecture:
As we can see, all layers are sequentially numbered, and this is very important, as this is exactly how the architecture flow works, from the graphical interface to the persistence of information in the database.*

**Authentication and Authorization with Bearer and JWT** Reference [Balta](https://balta.io/blog/aspnetcore-3-autenticacao-autorizacao-bearer-jwt).
>JWT is an industry standard (RFC-7519) that defines how to transmit and store JSON objects compactly and securely between different applications. The data contained therein can be validated at any time because the token is digitally signed. -Wellington Nascimento

**Swagger** Reference [Rebai Hamida](https://medium.com/@didourebai/add-swagger-to-asp-net-core-3-0-web-api-874cb265854c).
>Swagger is a simple yet powerful representation of your RESTful API. With the largest ecosystem of API tooling on the planet, thousands of developers are supporting Swagger in almost every modern programming language and deployment environment. With a Swagger-enabled API, you get interactive documentation, client SDK generation and discoverability. -Rebai Hamida

*For testing authentications, the valid values for user are {Username = "batman", Password = "batman"} or {Username = "robin", Password = "robin"}*

**Other features add to the project are:**
- dependency injection
- EntityFramework
- MySql database (*unfortunately could not create a cache, but my skills are recorded*)
- Validation with data annotations
*****
###### Note: All testing can be done by running abm_data_systems.API as the main project.

