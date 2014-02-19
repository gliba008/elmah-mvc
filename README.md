MNM.ELMAH.MVC
=========

This is just an extension for [ELMAH.MVC](https://github.com/alexanderbeletsky/elmah-mvc).

What is different?
------------------

- Added IElmahAuthorizer interface, which is used for custom authorizing.
- ElmahController is extended so it can use IElmahAuthorizer implementation.
- Bootstrap.Initialize() will not be called automatically and you must pass IElmahAuthorizer to it.

How to use it?
--------------

1. Implement IElmahAuthorizer interface and void DoAuthorization(AuthorizationContext filterContext) method. If authorization is not valid throw an exception, else just return from your method :D.

2. In the file ~/App_Start/RouteConfig.cs add following lines to the method void RegisterRoutes(RouteCollection routes):

    // Initialization of implementation of IElmahAuthorizer.
    ElmahAuthorizer authorizer = new ElmahAuthorizer();

    // Initialization of Elmah.Mvc module.
    Elmah.Mvc.Bootstrap.Initialize(authorizer);

3. Set up your settings in configuration file Web.config.

More or less, everything else is the same as in [ELMAH.MVC](https://github.com/alexanderbeletsky/elmah-mvc). This goes for configuration, authentification, users, roles and all the other stuff that you can set in Web.Config file.

Anything else?
--------------

Well I was searching for some sort of custom authorization for Elmah.Mvc (besides roles and users filtering) and I had no luck. So I wrote this tiny extension in few minutes and I decided that I would share it. Maybe it's not the smartest code right now, but I'll update it in the future because I hate unfinished and bad code.
Well I'm thinking right now maybe I could do it right away, BUT!!, it's 4 o'clock in the morning and maybe rewriting this now isn't such a good idea.
Or maybe it is, I don't know.

But when you are already here maybe I could tell you my intersting idea? Here it goes:

You know that song Angel of Harlem by U2? Yes, good. So the first verses go like this:

	It was a cold and wet December day,
	When we touched the ground at JFK, ...

It would be so cool if they would change this to honor Docot Who. It would go something like this:

	It was a cold and wet December day
	When I met a man from Gallifrey, ...

Would that be just awesome? I think so! Maybe Matt Smith would love it because he looks to me like a U2 fan.
To tell you the truth I'm not sure who's better Smith, Tennant or Ecclestone? Maybe Ecclestone, but I'm not 100% sure.
And so, the Gallifrey falls no more they say... That's good I think. Maybe :D Peter Capaldi would know better about that.

If you're asking yourself why did I write all this stuff, well, that's because It's already morning and there is no sense in sleeping right now.
Take care now, I'm going to sleep. 