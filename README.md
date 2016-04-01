ALPHA
========

## Routing: route models to controllers; "code so simple"; Loose Coupled Code

+ Routing setup (Controller Classes)
+ Call methods via routing
+ NuGet: Install-Package King.Route
+ 100% test coverage

## Notes

### Goals
From: http -> web api -> dal -> storage

To: http -> web api -> route -> dal -> route -> storage

### Benefits
+ High entropy, many smaller parts
+ multiple language support; route between languages
+ Models
 + Code MVC style
 + Model based throughout system, not just first layer
+ Testing
 + 1 mockable class: Get/Put, url + data
 + makes testing really nice, as you dont have to worry about mocking and dependancies as much
 + you don't inject classes that are dependancies

### Ideas
Controllers
+ Stateful? Should be able to load just one and keep using it? Cache Type.
+ Call type per route

Calling
+ Thread models, single threaded, eventing, etc.
+ Failures
+ App domains

Route Types
+ Direct Route, no-queue (done)
+ 

Routing is built into DNXCore: App.UseRouter(IRouter)
