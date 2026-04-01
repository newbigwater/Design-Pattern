#uml #plantUml 

```plantuml
skinparam handwritten true 
skinparam ParticipantPadding 50 
participant App as app 
participant Cache as cache 
database DB as db 

app -> cache: look up from cache 
alt if cache hit: 
app <-- cache: read from cache 
else if cache miss 
app x-- cache 
app -> db: read from db 
app <-- db: read from db 
app -> cache: update cache 
cache -> cache: write data 
end
```

```plantuml
skinparam handwritten true 
skinparam ParticipantPadding 50 

Alice -> Bob : Authentication Request
Bob --> Alice : Authentication Response

Alice -> Bob : Another authentication Request
Alice <-- Bob: another authentication Response
```

```plantuml
participant Participant [ 
	=Title 
	----
	""SubTitle"" 
] 

participant Bob
Participant -> Bob
```
![Pasted image 20240418104202.png|650](attachments/Pasted%20image%2020240418104202.png)
```plantuml
ref over Alice, Bob : init 

Alice -> Bob : hello 

ref over Bob 
	This can be on 
	several lines 
end ref
```

```plantuml
User -> A: DoWork 
activate A 

A -> B: << createRequest >> 
activate B 

B -> C: DoWork 
activate C 
C --> B: WorkDone 
destroy C 

B --> A: RequestCreated 
deactivate B 

A -> User: Done 
deactivate A
```

```plantuml
participant User
User -> A: DoWork
activate A #FFBBBB
A -> A: Internal call
activate A #DarkSalmon
A -> B: << createRequest >>
activate B
B --> A: RequestCreated
deactivate B
deactivate A
A -> User: Done
deactivate A
```
![Pasted image 20240418090327.png|650](attachments/Pasted%20image%2020240418090327.png)

```plantuml
autoactivate on
alice -> bob : hello
bob -> bob : self call
	bill -> bob #005500 : hello from thread 2
	bob -> george ** : create
	return done in thread 2
return rc
bob -> george !! : delete
return success
```
