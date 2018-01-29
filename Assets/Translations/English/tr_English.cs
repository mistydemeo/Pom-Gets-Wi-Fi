﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tr_English : _BaseTR
{
	void Start () {
        TranslationName = "English";
        TranslationCredits = ""; //Your name and anyone who helped you here!

        #region Character Names
        PomName = "Pom";
        ShibeName = "Shibe";
        AlmaName = "Alma";
        BernardName = "Bernard";
        BoldName = "Bold";
        ChiName = "Chi";
        CorgName = "Corg";
        CrestName = "Crest";
        DavePointerName = "Dave Pointer";
        DogName = "Dog";
        GlishName = "Glish";
        GoldieName = "Goldie";
        HusName = "Hus";
        LabraName = "Labra";
        MaltaName = "Malta";
        PapiName = "Papi";
        PuddleName = "Puddle";
        SharpeiName = "Sharpei";
        ShermanName = "Sherman";
        UgName = "Ug";
        WittyFidoName = "Witty Fido";
        YorkName = "York";
        #endregion

        //the following variables have to be configured in the Global object in the scene editor
        //Font - the font used by text in this translation

        langRegisterCode = EventPage.RegisterTranslation(this);

        //uncomment the next line out if you want to automatically test your new events when running the game
        //Global.ActiveLanguage = langRegisterCode;
    }

    public override void Initialize()
    {
        base.Initialize();
        var curLang = Global.ActiveLanguage.value;
        Global.ActiveLanguage.value = langRegisterCode;
        EventPage tempEP;
        var allowWalkEP = new EventPage(); allowWalkEP.Add(EventPlayerMoveable.c(true));

        //I'll try to keep this as well documented as I can, feel free to send me (Arazati) messages if you need any help or clarifications on anything :)

        //Some quick notes first of all;
        //-Each line can have 50 characters across, so count if you think you're using long lines, or test them ingame
        //-You can't use " inside of a string. Instead, you have to use two of ' so it's '',
        //      it gets automatically turned into a " in the textboxes so that's only one character

        #region Areas

        #region Intro

        //This is actually the longest event chain in the game, so it's a bit more complicated than most.
        //For the most part, each event page is done in order, with 4 potential sub events on 1, 2, and 3, which lets the player choose one of 4 websites.

        NewEP("67B10BC2-FCEF-4722-B7D7-B8BCB24B3F70");
        {
            var introIs0 = new EventPage();
            var introIs1 = new EventPage();
            var introIs2 = new EventPage();
            var introIs3 = new EventPage();
            var introIs4 = new EventPage();

            e = EventPageSwitch.c(Global.s.Intro). AddEventPage(0, introIs0). AddEventPage(1, introIs1). AddEventPage(2, introIs2). AddEventPage(3, introIs3). AddEventPage(4, introIs4);
            
            ep = introIs0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventBGM.c(BGM.Village2, .4f);
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom_no_laptop, @"the sun is shining");
                e = EventTextboxClearText.c;
                e = EventWait.c(.3f);
                e = EventTextbox.c(Faces.Pom_no_laptop, @"the birds are singing");
                e = EventTextboxClearText.c;
                e = EventWait.c(.3f);
                e = EventTextbox.c(Faces.Pom_no_laptop, @"it looks like the perfect day...");
                e = EventTextboxClose.c;
                e = EventChangeSprite.c(PlayerSprite.PillowAndLaptop);
                e = EventFlashScreen.c(.2f);
                e = EventWait.c(1f);
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"...to spend on the internet");
                e = EventTextboxClose.c;
                e = EventSetGlobal.c(Global.s.Intro, 1);
                e = EventPlayerMoveable.c(true);
            }

            #region Websites
            var facewoof = new EventPage();
            var reddig = new EventPage();
            var gTail = new EventPage();
            var tumfur = new EventPage();

            var choice = EventTextboxChoice.c.
                    AddChoice("Facewoof", facewoof, Global.s.Intro_Facewoof).
                    AddChoice("Reddig", reddig, Global.s.Intro_Reddig).
                    AddChoice("gTail", gTail, Global.s.Intro_gTail).
                    AddChoice("Tumfur", tumfur, Global.s.Intro_Tumfur);

            //Facewoof events
            ep = facewoof;
            {
                e = EventSetBackground.c(Background.Facewoof);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextbox.c(Faces.Pom, @"god
                                                stop posting pictures of ur fukkin food");
                e = EventTextbox.c(Faces.Pom, @"and showing off how much fun ur
                                                having without me");
                e = EventTextbox.c(Faces.Pom, @"no one wants to see ur pugly duck
                                                face either");
                e = EventTextbox.c(Faces.Pom, @"jfc");
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextbox.c(Faces.Pom, @"hey looks like my top pomeranians fb
                                                group has some new members");
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextbox.c(Faces.Pom, @"r u fucking kidding me");
                e = EventTextbox.c(Faces.Pom, @"these r all humans showing off
                                                their doges...");
                e = EventTextbox.c(Faces.Pom, @"plus some weird girl pretending
                                                to be a doge on the internet");
                e = EventTextbox.c(Faces.Pom, @"r u srsly telling me im the only legit
                                                pom pom doge on this website");
                e = EventTextbox.c(Faces.Pom, @"furget this");
                e = EventTextbox.c(Faces.Pom, @"i dont want to live on this planet
                                                anymore");
                e = EventTextbox.c(Faces.Pom, @"flies into the sun");
                e = EventSetBackground.c(Background.None);
                e = EventSetGlobal.c(Global.s.Intro_Facewoof, true);
            }

            //Reddig events
            ep = reddig;
            {
                e = EventSetBackground.c(Background.Reddig);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextbox.c(Faces.Pom, @"??????!!!!!!!");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"JESSUSUSUS CHSIRTS");
                e = EventTextbox.c(Faces.Pom, @"the mythbarkers r doing an AMA");
                e = EventTextbox.c(Faces.Pom, @"this is terrieriffic
                                                nows my chance to ask them all my 
                                                burning questions");
                e = EventTextbox.c(Faces.Pom, @"hhhhhhhhhhhhhhhhhhhhh");
                e = EventTextbox.c(Faces.Pom, @"all my comments will probably b
                                                buried tho");
                e = EventTextbox.c(Faces.Pom, @"lies down");
                e = EventSetBackground.c(Background.None);
                e = EventSetGlobal.c(Global.s.Intro_Reddig, true);
            }

            //gTail events
            ep = gTail;
            {
                e = EventSetBackground.c(Background.gTail);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextbox.c(Faces.Pom, @"lets see what i have here");
                e = EventTextbox.c(Faces.Pom, @"''Pom, it's not too late to apply!''
                                                ''Pom, picture yourself at Berkeley''");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"IM A FUKKIN POMERANIAN");
                e = EventTextbox.c(Faces.Pom, @"WTH DO U GUYS WANT FROM ME");
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextbox.c(Faces.Pom, @"hey its my SAT question of the day");
                e = EventTextbox.c(Faces.Pom, @"delete");
                e = EventTextbox.c(Faces.Pom, @"still not sure why i signed up for that");
                e = EventSetBackground.c(Background.None);
                e = EventSetGlobal.c(Global.s.Intro_gTail, true);
            }

            //Tumfur events
            ep = tumfur;
            {
                e = EventSetBackground.c(Background.Tumfur);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextbox.c(Faces.Pom, @"wow this fanart is amaze");
                e = EventTextbox.c(Faces.Pom, @"bless this drawing");
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextbox.c(Faces.Pom, @"wh");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"the arTIST IS FOURTEEN");
                e = EventTextbox.c(Faces.Pom, @"WHY THIS");
                e = EventTextbox.c(Faces.Pom, @"SO TALENT");
                e = EventTextbox.c(Faces.Pom, @"THIS ISNT POSSIBLE");
                e = EventTextbox.c(Faces.Pom, @"LEAPS INTO AN ACTIVE VOLCANO");
                e = EventSetBackground.c(Background.None);
                e = EventSetGlobal.c(Global.s.Intro_Tumfur, true);
            }

            #endregion
            
            ep = introIs1;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"now what should i check first");
                e = EventTextbox.c(Faces.Pom, @"first world problems");
                e = choice;
                e = EventTextboxClose.c;
                e = EventSetGlobal.c(Global.s.Intro, 2);
                e = EventPlayerMoveable.c(true);
            }
            
            ep = introIs2;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"next up is...");
                e = choice;
                e = EventSetBackground.c(Background.IntroNight);
                e = EventTextboxClose.c;
                e = EventSetGlobal.c(Global.s.Intro, 3);
                e = EventPlayerMoveable.c(true);
            }
            
            ep = introIs3;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"next...");
                e = choice;
                e = EventBGM.c(BGM.Burning, .6f);
                e = EventSetBackground.c(Background.IntroFire1);
                e = EventTextboxClose.c;
                e = EventSetGlobal.c(Global.s.Intro, 4);
                e = EventPlayerMoveable.c(true);
            }

            ep = introIs4;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"finally, I need to check...");
                e = EventSFX.c(SFX.Shibe_barking);
                //  \C[1]  is a color code for blue, \C[0] is for white.
                // This is the first time a name has to show up for no face. Otherwise it's automated. :)
                e = EventTextbox.c(Faces.None, @"\C[1]Voice\C[0]
                                YEEOWCH!");
                e = EventTextbox.c(Faces.None, @"\C[1]Voice\C[0]
                                F-f-fire! Fire!!!");
                e = EventTextbox.c(Faces.None, @"\C[1]Voice\C[0]
                                Master, wake up!");
                e = EventTextbox.c(Faces.None, @"\C[1]Voice\C[0]
                                You have to get out of here!");
                e = EventSFX.c(SFX.Shibe_barking);
                e = EventTextbox.c(Faces.None, @"\C[1]Voice\C[0]
                                Come on! This way!");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"wtf!!");
                e = EventTextbox.c(Faces.Pom, @"that fukkin shiba inu is so noisy");
                e = EventSFX.c(SFX.Shibe_barking);
                e = EventTextbox.c(Faces.None, @"\C[1]Shibe\C[0]
                                Huh? Pom, you're still in here?");
                e = EventTextbox.c(Faces.None, @"\C[1]Shibe\C[0]
                                We have to go!
                                Master is already waiting
                                outside!");
                e = EventTextbox.c(Faces.Pom, @"I SWEAR TO DOG");
                e = EventTextbox.c(Faces.Pom, @"IF YOU DONT SHADDUP IMMA
                                                FUKKIN KNOCK THE WALL DOWN");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"YA HEAR ME, SHIBE??");
                e = EventSFX.c(SFX.Shibe_barking);
                e = EventSFX.c(SFX.bump1);
                e = EventSFX.c(SFX.bump1);
                e = EventTextbox.c(Faces.None, @"\C[1]Shibe\C[0]
                                Pom, listen to me! Open your
                                door and run for it!");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"GO AWAY!!!!!!!!!!!");
                e = EventTextbox.c(Faces.None, @"\C[1]Shibe\C[0]
                                No! I'm not leaving without you!");
                e = EventSetBackground.c(Background.IntroFire2);
                e = EventTextbox.c(Faces.None, @"\C[1]Shibe\C[0]
                                Hurry! Th-th-the ceiling here
                                looks like it's about to collapse!");
                e = EventTextbox.c(Faces.None, @"\C[1]Shibe\C[0]
                                AIIEEEEEE!!!");
                e = EventTextboxClose.c;
                e = EventSFX.c(SFX.fire8);
                e = EventSFX.c(SFX.earth08);
                e = EventWait.c(3.3f);
                e = EventTextbox.c(Faces.Pom, @"finally that dum shibe shut up");
                e = EventTextbox.c(Faces.Pom, @"is it just me or is it hella hot in here");
                e = EventTextbox.c(Faces.Pom, @"our owner should turn up the air 
                                                conditioning");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"HEY OWNER!!");
                e = EventTextbox.c(Faces.Pom, @"AIR CONDITIONING!!!");
                e = EventSetBackground.c(Background.IntroFire3);
                e = EventTextboxClose.c;
                e = EventWait.c(1.5f);
                e = EventTextbox.c(Faces.Pom, @"*koffing*");
                e = EventTextbox.c(Faces.Pom, @"*wheezing*");
                e = EventTextboxClose.c;
                e = EventFlashScreen.c(2.5f);
                e = EventPixelize.c;
                e = EventFlashScreen.c(0f, Color.black);
                e = EventWait.c(2f);
                e = EventBGM.c(BGM.Eeternal);
                e = EventSetGlobal.c(Global.s.Intro, 6);
                e = EventChangeSprite.c(PlayerSprite.Normal);
                e = EventTPPlayer.c(new Vector2(-69.5f, -21.5f)).instantTeleport;
                e = EventFlashScreen.c(0f, new Color(0f, 0f, 0f, 0f));
                e = EventUnPixelize.c;
                e = EventWait.c(2f);

                e = EventTextbox.c(Faces.Pom, @"huh");
                e = EventTextbox.c(Faces.Pom, @"this is much better");
                e = EventSetWebsiteSelector.c;
                // i'm sorry for this mess.. only one of these will trigger based on what the player -didn't- select before
                {
                    var tumfurLeft = new EventPage();
                    var reddigLeft = new EventPage();
                    var gTailLeft = new EventPage();
                    var facewoofLeft = new EventPage();

                    tumfurLeft.Add(EventTextbox.c(Faces.Pom,   @"now i can finally finish my daily
                                                                 rounds and check tumfur..."));
                    reddigLeft.Add(EventTextbox.c(Faces.Pom,   @"now i can finally finish my daily
                                                                 rounds and check reddig..."));
                    gTailLeft.Add(EventTextbox.c(Faces.Pom,    @"now i can finally finish my daily
                                                                 rounds and check gTail..."));
                    facewoofLeft.Add(EventTextbox.c(Faces.Pom, @"now i can finally finish my daily
                                                                 rounds and check facewoof..."));

                    e = EventPageSwitch.c(Global.s.Intro_LastWebsiteSelector).AddEventPage(0, facewoofLeft).AddEventPage(1, reddigLeft).AddEventPage(2, gTailLeft).AddEventPage(3, tumfurLeft);
                }

                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextbox.c(Faces.Pom, @"EH????????");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventShake.c(.4f);
                e = EventTextbox.c(Faces.Pom, @"THERES NO WI-FI");
                e = EventTextbox.c(Faces.Pom, @"JUST KILL ME NOW");
                e = EventTextbox.c(Faces.Pom, @"WAT DID I EVER DO 2 DESERVE
                                                THIS");
                e = EventTextbox.c(Faces.Pom, @"I;M CRY");
                e = EventTextbox.c(Faces.Pom, @"GROSS SOBBING");
                e = EventTextbox.c(Faces.Pom, @"sniff");
                e = EventTextbox.c(Faces.Pom, @"sniff");
                e = EventTextbox.c(Faces.Pom, @"sniff");
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextbox.c(Faces.Pom, @"nows not the time 2 b wallowing
                                                in self pity");
                e = EventTextbox.c(Faces.Pom, @"i gotta get up and do something 
                                                about this!!");
                e = EventTextbox.c(Faces.Pom, @"ye a");
                e = EventTextbox.c(Faces.Pom, @"!!!");
                e = EventTextbox.c(Faces.Pom, @"inspire");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }
        #endregion
        
        #region Field

        //Talking to shibe when you first enter the field
        NewEP("5c0579a0-63db-4383-a307-188f4a0f6645");
        {
            tempEP = new EventPage(); e = EventPageSwitch.c(Global.s.ShibeIntro).AddEventPage(1, tempEP); ep = tempEP;
            e = EventPlayerMoveable.c(false);
            e = EventSetGlobal.c(Global.s.IntroGround, 1);
            e = EventSetGlobal.c(Global.s.ShibeIntro, 3);
            e = EventSetGlobal.c(Global.s.ShibeTalk, 1);
            e = EventSFX.c(SFX.Medium_Dog1);
            e = EventTextbox.c(Faces.Shibe, @"Pom!");
            e = EventTextbox.c(Faces.Pom, @"poopy head!");
            e = EventTextbox.c(Faces.Shibe, @"I'm glad you didn't get hurt in
                                              the fire!!");
            e = EventTextbox.c(Faces.Shibe, @"Do you know where we are?");
            e = EventTextbox.c(Faces.Shibe, @"I was waiting outside your room
                                              when--");
            e = EventTextbox.c(Faces.Pom, @"uh eXCUSE U???????");
            e = EventTextbox.c(Faces.Pom, @"i AM hurt");
            e = EventTextbox.c(Faces.Pom, @"in da KOKORO!!!!");
            e = EventTextbox.c(Faces.Shibe_uh, @"Huh?");
            e = EventTextbox.c(Faces.Pom, @"now help me look for wi-fi");
            e = EventTextbox.c(Faces.Shibe_uh, @"What? But...");
            e = EventTextbox.c(Faces.Shibe_uh, @"Isn't it more important that we
                                                 figure out how to get home first?");
            e = EventTextbox.c(Faces.Shibe, @"We can worry about the wi-fi
                                              later.");
            e = EventTextbox.c(Faces.Pom, @"what the fuk did u just fukkin say 2
                                            me u lil bitch");
            e = EventTextbox.c(Faces.Pom, @"ur fukkin ded kiddo");
            e = EventTextboxClose.c;
            e = EventBattle.c(Battles.Shibe);
            e = EventSetGlobal.c(Global.s.FlowerField, 1);
            e = EventTextbox.c(Faces.Pom, @"ok shibe");
            e = EventTextbox.c(Faces.Pom, @"from now on ur my manservant");
            e = EventTextbox.c(Faces.Pom, @"i can talk 2 u whenever i want by
                                            facing u and pressing da z key");
            e = EventTextbox.c(Faces.Pom, @"also ive changed ur name 2
                                            sebastian");
            e = EventTextbox.c(Faces.Shibe_annoyed, @"Why the hell am I ''Sebastian''?!");
            e = EventTextbox.c(Faces.None, @"Shibe has joined the party!").DontSlide;
            e = EventSetGlobal.c(Global.s.ShibeInParty, 1);
            e = EventTextboxClose.c;
            e = EventPlayerMoveable.c(true);
        }

        //cherry blossom trees
        NewEP("ba0b6a84-07ed-46da-b0d6-a4b541c0b52f");
        {
            var shibeInParty = new EventPage();
            var shibeNotInparty = new EventPage();
            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(1, shibeInParty).AddEventPage(1, shibeNotInparty, SwitchComparator.NotEqual);

            ep = shibeNotInparty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeInParty;
            {
                var silentTreatment = new EventPage();
                var notSilentTreatment = new EventPage();
                e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, silentTreatment, SwitchComparator.NotEqual)
                                                              .AddEventPage(0, notSilentTreatment);

                ep = silentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"hey shibe");
                    e = EventTextbox.c(Faces.Shibe_uh, @"...");
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = notSilentTreatment;
                {
                    var cherryBlossomsSeen = new EventPage();
                    var cherryBlossomsNotSeen = new EventPage();
                    e = EventPageSwitch.c(Global.s.Cherry_Blossoms).AddEventPage(0, cherryBlossomsNotSeen)
                                                                 .AddEventPage(0, cherryBlossomsSeen, SwitchComparator.NotEqual);

                    ep = cherryBlossomsNotSeen;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Pom, @"perfect these r cherry blossoms");
                        e = EventTextbox.c(Faces.Pom, @"shibe stand over here");
                        e = EventTextbox.c(Faces.Shibe_uh, @"Huh?");
                        e = EventTextbox.c(Faces.Pom, @"say ''a new year a new start''");
                        e = EventTextbox.c(Faces.Pom, @"''i hope senpai notices me''");
                        e = EventTextbox.c(Faces.Shibe_uh, @"A new year, a ne-");
                        e = EventSFX.c(SFX.Pom_bark);
                        e = EventTextbox.c(Faces.Pom, @"NO ur doin it wrong");
                        e = EventTextbox.c(Faces.Pom, @"''a new year a new start''");
                        e = EventTextbox.c(Faces.Pom, @"not ''A new year, a new start.''");
                        e = EventTextbox.c(Faces.Pom, @"try 2 say it in comic sans too");
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"I have no idea what you're trying to
                                                                  tell me!");
                        e = EventSetGlobal.c(Global.s.Cherry_Blossoms, 1);
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = cherryBlossomsSeen;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Pom, @"what kind of shibe r u");
                        e = EventTextbox.c(Faces.Pom, @"cant even speak in comic sans");
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"I still don't get what I did wrong!");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }
            }
        }


        #endregion

        #region Flower Field Town

        // Big White Rose
        NewEP("F9794751-D80A-41DA-9888-83E57059A4F1");
        {
            {
                var shibeInParty = new EventPage();
                var shibeNotInparty = new EventPage();
                e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(1, shibeInParty).AddEventPage(1, shibeNotInparty, SwitchComparator.NotEqual);

                ep = shibeNotInparty;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = shibeInParty;
                {
                    var silentTreatment = new EventPage();
                    var notSilentTreatment = new EventPage();
                    e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, silentTreatment, SwitchComparator.NotEqual)
                                                                  .AddEventPage(0, notSilentTreatment);

                    ep = silentTreatment;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Pom, @"hey shibe");
                        e = EventTextbox.c(Faces.Shibe_uh, @"...");
                        e = EventTextbox.c(Faces.Pom, @"...");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = notSilentTreatment;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe, @"This flower is so tall");
                        e = EventTextbox.c(Faces.Pom, @"If normal roses r Kuroko then
                                            this one is Kagami");
                        e = EventTextbox.c(Faces.Shibe_uh, @"...Sometimes I really can't understand
                                                 what you're saying.");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }
            }
        }

        // Big Black/Purple Rose
        NewEP("95b58f5e-4227-4d69-97e6-f005ce41f5d4");
        {
            {
                {
                    var shibeInParty = new EventPage();
                    var shibeNotInparty = new EventPage();
                    e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(1, shibeInParty).AddEventPage(1, shibeNotInparty, SwitchComparator.NotEqual);

                    ep = shibeNotInparty;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Pom, @"...");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = shibeInParty;
                    {
                        var silentTreatment = new EventPage();
                        var notSilentTreatment = new EventPage();
                        e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, silentTreatment, SwitchComparator.NotEqual)
                                                                      .AddEventPage(0, notSilentTreatment);

                        ep = silentTreatment;
                        {
                            e = EventPlayerMoveable.c(false);
                            e = EventTextbox.c(Faces.Pom, @"hey shibe");
                            e = EventTextbox.c(Faces.Shibe_uh, @"...");
                            e = EventTextbox.c(Faces.Pom, @"...");
                            e = EventTextboxClose.c;
                            e = EventPlayerMoveable.c(true);
                        }

                        ep = notSilentTreatment;
                        {
                            e = EventPlayerMoveable.c(false);
                            e = EventTextbox.c(Faces.Pom, @"wouldnt it have been funny if garry
                                            had to carry around a rose this big");
                            e = EventTextbox.c(Faces.Shibe_annoyed, @"Who the heck is ''Garry''?!");
                            e = EventTextboxClose.c;
                            e = EventPlayerMoveable.c(true);
                        }
                    }
                }
            }
        }

        var enteredCrestAndPuddlesHouse = new EventPage();
        //Crest and Puddle's House teleport door.
        NewEP("393fae68-8399-49bd-9973-37a04aff48ec");
        {
            var crestStalkFest0 = new EventPage();
            var crestStalkFest1to8 = new EventPage();
            var crestStalkFest9plus = new EventPage();
            
            e = EventPageSwitch.c(Global.s.CrestStalkFest).AddEventPage(0, crestStalkFest0).
                                                           AddEventPage(8, crestStalkFest1to8, SwitchComparator.LessOrEqual).
                                                           AddEventPage(9, crestStalkFest9plus, SwitchComparator.GreaterOrEqual);

            ep = crestStalkFest0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTPPlayer.c(new Vector2(-10.5f, -53.5f), SpriteDir.Up);
                e = EventPageExecute.c(enteredCrestAndPuddlesHouse);
                e = EventPlayerMoveable.c(true);
            }

            ep = crestStalkFest1to8;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe_uh, @"It's locked.");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = crestStalkFest9plus;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"it's locked");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        #endregion

        #region Sharpei's House

        //Funyarinpa
        NewEP("6dd2fb8b-a541-408f-be90-b2f204358c6a");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeInParty;
            {
                var silentTreatment = new EventPage();
                var notSilentTreatment = new EventPage();

                e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, notSilentTreatment).AddEventPage(1, silentTreatment);

                ep = silentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"hey shibe");
                    e = EventTextbox.c(Faces.Shibe_uh, @"...");
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = notSilentTreatment;
                {
                    var notSeenFunyarinpa = new EventPage();
                    var seenFunyarinpa = new EventPage();

                    e = EventPageSwitch.c(Global.s.Funyarinpa).AddEventPage(0, notSeenFunyarinpa).AddEventPage(1, seenFunyarinpa);

                    ep = notSeenFunyarinpa;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventSetBackground.c(Background.Funyarinpa);
                        e = EventWait.c(1f);
                        e = EventTextbox.c(Faces.Shibe_uh, @"What's this picture supposed to be?");
                        e = EventTextbox.c(Faces.Pom, @"looks like kawoshin fanart");
                        e = EventTextbox.c(Faces.Shibe_uh, @"Huh?");
                        e = EventTextbox.c(Faces.Pom, @"c
                                                        dis part here is shinjis butt");
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"There's no way that's what this is!");
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"Who on earth would hang up a picture
                                                                  of something like that?!");
                        e = EventTextbox.c(Faces.Pom, @"i would");
                        e = EventTextbox.c(Faces.Shibe_uh, @"Anyway, doesn't this look more like
                                                             a picture of a dog?");
                        e = EventTextbox.c(Faces.Shibe_uh, @"It's standing in the center.");
                        e = EventTextboxOnlyBG.c;
                        e = EventWait.c(2.5f);
                        e = EventTextbox.c(Faces.Pom, @"oh i c it now");
                        e = EventTextbox.c(Faces.Pom, @"darn");
                        e = EventTextbox.c(Faces.Sharpeii, @"You're wrong!");
                        e = EventTextbox.c(Faces.Shibe_uh, @"H-huh?");
                        e = EventTextbox.c(Faces.Sharpeii, @"This picture isn't of a mere dog.");
                        e = EventTextbox.c(Faces.Sharpeii, @"It's the funyarinpa!");
                        e = EventTextbox.c(Faces.Pom, @"what the hell is a funyarinpa");
                        e = EventSFX.c(SFX.fire8);
                        e = EventShake.c(5, 5, .2f);
                        e = EventTextbox.c(Faces.Sharpeii, @"What do you mean ''What the hell is
                                                             a funyarinpa''?!");
                        e = EventTextbox.c(Faces.Sharpeii, @"You mean...you don't know?!");
                        e = EventSFX.c(SFX.Pom_bark);
                        e = EventTextbox.c(Faces.Pom, @"how the hell would i know!?");
                        e = EventTextbox.c(Faces.Sharpeii, @"How could you not know?!
                                                             That...that's practically blasphemous.");
                        e = EventTextbox.c(Faces.Sharpeii, @"Say you're sorry!
                                                             Apologize to the funyarinpa!");
                        e = EventTextbox.c(Faces.Sharpeii, @"Goodness, you are such a rude
                                                             pomeranian.");
                        e = EventSetGlobal.c(Global.s.Funyarinpa, 1);
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = seenFunyarinpa;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventSetBackground.c(Background.Funyarinpa);
                        e = EventWait.c(1f);
                        e = EventTextbox.c(Faces.Shibe_uh, @"...Was he just screwing around with
                                                             us?");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }
            }
        }

        //Rocket
        NewEP("5da5b1ba-1243-4099-be86-dab1485d3af0");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeInParty;
            {
                var silentTreatment = new EventPage();
                var notSilentTreatment = new EventPage();

                e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, notSilentTreatment).AddEventPage(1, silentTreatment);

                ep = silentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"hey shibe");
                    e = EventTextbox.c(Faces.Shibe_uh, @"...");
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = notSilentTreatment;
                {
                    var rocket0 = new EventPage();
                    var rocket1 = new EventPage();
                    var rocket2plus = new EventPage();

                    e = EventPageSwitch.c(Global.s.Rocket).AddEventPage(0, rocket0).AddEventPage(1, rocket1).AddEventPage(2, rocket2plus, SwitchComparator.GreaterOrEqual);

                    ep = rocket0;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe, @"This looks like a model of a
                                                          rocket.");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = rocket1;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe, @"This looks like a model of a
                                                          rocket.");
                        e = EventSFX.c(SFX.Pom_bark);
                        e = EventTextbox.c(Faces.Pom, @"shit
                                                        i accidentally just broke a little
                                                        piece of it off");
                        e = EventTextbox.c(Faces.Pom, @"let's blame it on that brat upstairs ok");
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"Are you trying to turn these two
                                                                  against each other?!");
                        e = EventSetGlobal.c(Global.s.Rocket, 2);
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = rocket2plus;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"I wonder when he'll notice it...");
                        e = EventTextbox.c(Faces.Pom, @"never");
                        e = EventTextbox.c(Faces.Shibe_uh, @"How are we going to pull that off?");
                        e = EventTextbox.c(Faces.Pom, @"we kill him");
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"Just to stop him from finding out that
                                                                  you broke off a piece of his model?!");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }
            }
        }

        //Floor2 - Titanic
        NewEP("f2ff3774-7659-4f3f-8498-09b1c769e7b0");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeInParty;
            {
                var silentTreatment = new EventPage();
                var notSilentTreatment = new EventPage();

                e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, notSilentTreatment).AddEventPage(1, silentTreatment);

                ep = silentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"hey shibe");
                    e = EventTextbox.c(Faces.Shibe_uh, @"...");
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = notSilentTreatment;
                {
                    var rocket0 = new EventPage();
                    var rocket1plus = new EventPage();

                    e = EventPageSwitch.c(Global.s.Rocket).AddEventPage(0, rocket0).AddEventPage(1, rocket1plus, SwitchComparator.GreaterOrEqual);

                    ep = rocket0;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe, @"This looks like a replica of the
                                                          Titanic.");
                        e = EventSFX.c(SFX.Pom_bark);
                        e = EventTextbox.c(Faces.Pom, @"fuk
                                                        i accidentally just broke a little
                                                        piece of it off");
                        e = EventTextbox.c(Faces.Pom, @"let's blame it on that old fart downstairs");
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"I don't want to have any part in
                                                                  this!");
                        e = EventSetGlobal.c(Global.s.Rocket, 1);
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = rocket1plus;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"We probably shouldn't touch this
                                                                  anymore.");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }
            }
        }

        //Birdcage
        NewEP("f9cfa717-a418-42a7-a74e-d643eca28ba0");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeInParty;
            {
                var silentTreatment = new EventPage();
                var notSilentTreatment = new EventPage();

                e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, notSilentTreatment).AddEventPage(1, silentTreatment);

                ep = silentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"hey shibe");
                    e = EventTextbox.c(Faces.Shibe_uh, @"...");
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = notSilentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Shibe, @"It's a birdcage.");
                    e = EventTextbox.c(Faces.Shibe, @"There's nothing inside, though.");
                    e = EventTextbox.c(Faces.Pom, @"we should put u inside");
                    e = EventTextbox.c(Faces.Shibe_annoyed, @"No!");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }
            }
        }

        //Floor2 - Garbage
        NewEP("16335bfe-31c0-404a-8521-bad2b3f0e4b0");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeNotInParty;
            {
                var junkPile0 = new EventPage();
                var junkPile1 = new EventPage();
                var junkPile2 = new EventPage();

                e = EventPageSwitch.c(Global.s.JunkPile).AddEventPage(0, junkPile0).AddEventPage(1, junkPile1).AddEventPage(2, junkPile2);

                ep = junkPile0;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = junkPile1;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"huh? what's that");
                    e = EventTextbox.c(Faces.Pom, @"HEY");
                    e = EventSFX.c(SFX.Pom_bark);
                    e = EventTextbox.c(Faces.Pom, @"I FOUND THE CORG-KEYS");
                    e = EventTextbox.c(Faces.York, @"Hey! You can't just take those!");
                    e = EventTextbox.c(Faces.Pom, @"2 bad 4 u");
                    e = EventTextbox.c(Faces.Pom, @"i need them");

                    var hasRootbeer = new EventPage();
                    var noRootbeer = new EventPage();

                    e = EventPageSwitch.c(Global.s.RootBeer).AddEventPage(0, noRootbeer).AddEventPage(1, hasRootbeer);

                    ep = hasRootbeer;
                    {
                        e = EventTextbox.c(Faces.Pom, @"how about I trade this 2 u for this
                                                        root beer float from starpugs");
                        e = EventSFX.c(SFX.fire8);
                        e = EventShake.c(5, 5, .2f);
                        e = EventTextbox.c(Faces.York, "");
                        e = EventTextboxClearText.c;
                        e = EventWait.c(.2f);
                        e = EventTextbox.c(Faces.York, @"You have a root beer float?!");
                        e = EventTextbox.c(Faces.York, @"Okay, deal!");
                        e = EventTextbox.c(Faces.None, @"You gave the root beer float to York.");
                        e = EventSetGlobal.c(Global.s.RootBeer, 0);
                        e = EventTextbox.c(Faces.None, @"You received the Corg-Keys!");
                        e = EventSetGlobal.c(Global.s.CorgKeys, 1);
                        e = EventSetGlobal.c(Global.s.JunkPile, 2);
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = noRootbeer;
                    {
                        e = EventTextboxClose.c;
                        e = EventBattle.c(Battles.York);
                        e = EventTextbox.c(Faces.Pom, @"they're mine now");
                        e = EventTextbox.c(Faces.Pom, @"uwee hee");
                        e = EventSetGlobal.c(Global.s.CorgKeys, 1);
                        e = EventTextbox.c(Faces.None, @"You obtained the Corg-Keys!");
                        e = EventSetGlobal.c(Global.s.JunkPile, 2);
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }

                ep = junkPile2;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"there's nothing else important in here");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }
            }

            ep = shibeInParty;
            {
                var silentTreatment = new EventPage();
                var notSilentTreatment = new EventPage();

                e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, notSilentTreatment).AddEventPage(1, silentTreatment);

                ep = silentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"hey shibe");
                    e = EventTextbox.c(Faces.Shibe_uh, @"...");
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = notSilentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Shibe_uh, @"It looks like a pile of junk.").SwitchSides;
                    e = EventTextbox.c(Faces.York, @"Oh, that's all stuff I scavenged from
                                                     trash.");
                    e = EventTextbox.c(Faces.York, @"There's some really valuable things
                                                     in there, you know.");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }
            }
        }

        #endregion

        #region Crest and Puddle's House

        //Hearts
        NewEP("14513af2-9f23-4247-b310-923777a8dcba");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"did yuo kno");
                e = EventTextbox.c(Faces.Pom, @"girls need cute things or else
                                                they'll die");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Big Bunny
        NewEP("53d67977-8932-4bf7-ab5e-67652d73b2b2");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"DOG FUKKING DAMMIT
                                                I LOVE BUNNIES");
                e = EventTextbox.c(Faces.Pom, @"PUNCH ME IN DA DICK");
                e = EventTextbox.c(Faces.Shibe_uh, @"E-excuse me?!");
                e = EventTextbox.c(Faces.Pom, @"it's just a figure of speech");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Trophy
        NewEP("3fbed45b-7cf5-4123-a01c-018b1c2ea226");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"dis is a best in show trophy");
                e = EventTextbox.c(Faces.Shibe_uh, @"Whoa! It's from a national competition.");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Oven
        NewEP("0793e0e7-c92d-4555-b0c1-eb8933df94b5");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe_uh, @"This is a really pink oven.").SwitchSides;
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Trigger when you enter the house
        ep = enteredCrestAndPuddlesHouse;
        {
            var crestTalk2 = new EventPage();

            e = EventPageSwitch.c(Global.s.CrestTalk).AddEventPage(2, crestTalk2);

            ep = crestTalk2;
            {
                e = EventPlayerMoveable.c(false);
                e = EventMovePlayer.c(Up);
                e = EventSetFacing.c(NPC.Shibe, SpriteDir.Up);
                e = EventWait.c(1f);
                e = EventSFX.c(SFX.Pom_bark);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Crest_crying, @"HELP!");
                e = EventTextbox.c(Faces.Crest_crying, @"I'M TRAPPED!");
                e = EventTextbox.c(Faces.Pom, @"u ok");
                e = EventTextbox.c(Faces.Crest_crying, @"Don't you see?
                                                         There's a spider over there!");
                e = EventTextboxClose.c;
                e = EventWait.c(.1f);
                e = EventMovePlayer.c(Left, NPC.Spider, Speed.HalfNormal);
                e = EventMovePlayer.c(Right, NPC.Spider, Speed.HalfNormal);
                e = EventWait.c(1f);
                e = EventTextbox.c(Faces.Shibe_annoyed, @"That black speck?!").SwitchSides;
                e = EventTextbox.c(Faces.Shibe_annoyed, @"It's tiny!").SwitchSides;
                e = EventTextbox.c(Faces.Crest_crying, @"Normally Puddle takes care of the
                                                         spiders, but she's not home...");
                e = EventTextbox.c(Faces.Pom, @"y dont u just go kill it with a
                                                tissue");
                e = EventTextbox.c(Faces.Crest_crying, @"What if I try to get it...and it dodges?!");
                e = EventTextbox.c(Faces.Crest_crying, @"And then crawls onto my paw?!");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"Oh, come on!
                                                          What's going to happen if it crawls on you?").SwitchSides;
                e = EventSFX.c(SFX.Pom_bark);
                e = EventSFX.c(SFX.fire8);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Crest_crying, @"I'LL DIE!");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"That's impossible!").SwitchSides;
                e = EventSetGlobal.c(Global.s.ShibeTalk, 10);
                e = EventSetGlobal.c(Global.s.CrestTalk, 4);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //spider
        NewEP("0c7de9b0-5a00-466d-9dd9-ef31f819c14c");
        {
            var crestTalk4 = new EventPage();

            e = EventPageSwitch.c(Global.s.CrestTalk).AddEventPage(4, crestTalk4);

            ep = crestTalk4;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"greetings spider");
                e = EventTextbox.c(Faces.Pom, @"today u meet ur doom");
                e = EventTextbox.c(Faces.Shibe_uh, @"Can't we just coax it outside?");
                e = EventTextbox.c(Faces.Shibe_uh, @"There's no real need to kill it.");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Crest, @"No! Then it might make more
                                                  spiders!");
                e = EventTextbox.c(Faces.Crest, @"You have to kill it!");
                e = EventTextbox.c(Faces.Pom, @"fufufu");
                e = EventTextboxClose.c;
                e = EventWait.c(1f);
                e = EventSFX.c(SFX.damage1);
                e = EventSetGlobal.c(Global.s.CrestTalk, 5);
                e = EventWait.c(1f);
                e = EventTextbox.c(Faces.Pom, @"it hath been slain");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Crest, @"THANK YOU THANK YOU
                                                  THANK YOU!!!");
                e = EventTextboxClose.c;
                e = EventSetFacing.c(NPC.Crest, SpriteDir.Left);
                e = EventMovePlayer.c(Left, NPC.Crest, Speed.HalfNormal);
                e = EventMovePlayer.c(Left, NPC.Crest, Speed.HalfNormal);
                e = EventMovePlayer.c(Left, NPC.Crest, Speed.HalfNormal);
                e = EventMovePlayer.c(Left, NPC.Crest, Speed.HalfNormal);
                e = EventMovePlayer.c(Left, NPC.Crest, Speed.HalfNormal);
                e = EventMovePlayer.c(Left, NPC.Crest, Speed.HalfNormal);
                e = EventMovePlayer.c(Left, NPC.Crest, Speed.HalfNormal);
                e = EventMovePlayer.c(Left, NPC.Crest, Speed.HalfNormal);
                e = EventMovePlayer.c(Left, NPC.Crest, Speed.HalfNormal);
                e = EventMovePlayer.c(Left, NPC.Crest, Speed.HalfNormal);
                e = EventTextbox.c(Faces.Shibe_uh, @"You don't have to shout!").SwitchSides;
                e = EventTextboxClose.c;
                e = EventSetGlobal.c(Global.s.CrestTalk, 7);
                e = EventSetGlobal.c(Global.s.PuddleTalk, 2);
                e = EventSFX.c(SFX.close1);
                e = EventTPPlayer.c(new Vector2(-11.5f, -53.5f), SpriteDir.Up, NPC.Puddle).instantTeleport;
                e = EventTPPlayer.c(new Vector2(-6.5f, -50.5f), SpriteDir.Left, NPC.Crest).instantTeleport;
                e = EventMovePlayer.c(Up, NPC.Puddle, Speed.HalfNormal);
                e = EventSetFacing.c(NPC.Puddle, SpriteDir.Left);
                e = EventWait.c(.2f);
                e = EventSetFacing.c(NPC.Puddle, SpriteDir.Right);
                e = EventWait.c(.2f);
                e = EventSetFacing.c(NPC.Puddle, SpriteDir.Up);
                e = EventWait.c(.2f);
                e = EventTextbox.c(Faces.Puddle, @"Huh?
                                                   What's all this commotion?");
                e = EventTextbox.c(Faces.Crest, @"These two just saved my life!");
                e = EventTextbox.c(Faces.Shibe_uh, @"Not really...").SwitchSides;
                e = EventTextbox.c(Faces.Puddle, @"I should be thanking you, then.");
                e = EventTextbox.c(Faces.Puddle, @"Here, have this. For saving Crest's
                                                   life.");
                e = EventTextbox.c(Faces.None, @"You received a large inflatable
                                                 dolphin.");
                e = EventTextbox.c(Faces.Shibe_uh, @"Thanks, I guess...").SwitchSides;
                e = EventSetGlobal.c(Global.s.HasDolphie, 1);

                var goldieTalk5plus = new EventPage();
                var goldieTalk4less = new EventPage();

                e = EventPageSwitch.c(Global.s.GoldieTalk).AddEventPage(5, goldieTalk5plus, SwitchComparator.GreaterOrEqual).AddEventPage(4, goldieTalk4less, SwitchComparator.LessOrEqual);

                ep = goldieTalk5plus;
                {
                    e = EventSetGlobal.c(Global.s.ShibeTalk, 11);
                }

                ep = goldieTalk4less;
                {
                    var hasFamicom = new EventPage();
                    var dontHaveFamicom = new EventPage();

                    e = EventPageSwitch.c(Global.s.HasFamicom).AddEventPage(1, hasFamicom).AddEventPage(0, dontHaveFamicom);
                    ep = hasFamicom; { e = EventSetGlobal.c(Global.s.ShibeTalk, 9); }

                    ep = dontHaveFamicom;
                    {
                        var goldieTalk3 = new EventPage();
                        var goldieTalkNot3 = new EventPage();

                        e = EventPageSwitch.c(Global.s.GoldieTalk).AddEventPage(3, goldieTalk3).AddEventPage(3, goldieTalkNot3, SwitchComparator.Less).AddEventPage(3, goldieTalkNot3, SwitchComparator.Greater);
                        ep = goldieTalk3; { e = EventSetGlobal.c(Global.s.ShibeTalk, 8); }
                        ep = goldieTalkNot3; { e = EventSetGlobal.c(Global.s.ShibeTalk, 7); }
                    }
                }

                ep = crestTalk4;
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
                e = EventSetGlobal.c(Global.s.PuddleTalk, 3);
            }
        }

        //Trying to leave crest with the spider, you monster
        NewEP("5c1be82e-c640-45f7-945c-9507489f2e59");
        {
            e = EventPlayerMoveable.c(false);
            e = EventTextbox.c(Faces.Shibe_uh, @"I think we should help Crest...");
            e = EventTextboxClose.c;
            e = EventPlayerMoveable.c(true);
        }
        
        #endregion

        #region Park

        //Stone Block
        NewEP("b29aa692-3b2f-4849-9656-a851e2409842");
        {
            var parkNotFixed = new EventPage();
            var parkFixed = new EventPage();

            e = EventPageSwitch.c(Global.s.ParkState).AddEventPage(1, parkNotFixed, SwitchComparator.LessOrEqual).AddEventPage(2, parkFixed);

            ep = parkNotFixed;
            {
                var sbs0 = new EventPage();
                var sbs3 = new EventPage(); var sbs5 = new EventPage();
                var sbs6 = new EventPage(); var sbs7 = new EventPage();
                var sbs8 = new EventPage(); var sbs9 = new EventPage();

                e = EventPageSwitch.c(Global.s.StoneBlockSearch).AddEventPage(2, sbs0, SwitchComparator.LessOrEqual).AddEventPage(3, sbs3).AddEventPage(5, sbs5).AddEventPage(6, sbs6).AddEventPage(7, sbs7).AddEventPage(8, sbs8).AddEventPage(9, sbs9);

                ep = sbs0;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"a rock thing");
                    e = EventTextbox.c(Faces.Shibe, @"There's some text carved onto it.");
                    e = EventTextbox.c(Faces.Shibe, @"It says ''Park.''");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = sbs3;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Shibe_uh, @"...?");
                    e = EventTextbox.c(Faces.Pom, @"what is it u dum shibe");
                    e = EventTextbox.c(Faces.Shibe_uh, @"What if we used this rock thing as
                                                         leverage to climb over the fence?");
                    e = EventTextbox.c(Faces.Shibe_uh, @"Then we could get into the park and see
                                                         what the problem in there is.");
                    e = EventTextbox.c(Faces.Pom, @"the fence looks too high to climb even
                                                    standing on top of the rock tho");
                    e = EventTextbox.c(Faces.Pom, @"it would be great if they'd made this
                                                    rock taller");
                    e = EventTextbox.c(Faces.Shibe_uh, @"...That's it!");
                    e = EventTextbox.c(Faces.Shibe, @"We should make it taller!");
                    e = EventTextbox.c(Faces.Pom, @"???");
                    e = EventTextbox.c(Faces.Shibe, @"We have these books, right?");
                    e = EventSetGlobal.c(Global.s.StoneBlockSearch, 4);
                    e = EventTextboxClose.c;
                    e = EventWait.c(1f);
                    e = EventTextbox.c(Faces.Shibe, @"See, if we stack them on the rock, it's
                                                      a little taller.");
                    e = EventTextbox.c(Faces.Pom, @"still not tall enough tho");
                    e = EventTextbox.c(Faces.Shibe_uh, @"Yeah...looks like we'll have to get more
                                                         stuff to stack on it.");
                    e = EventSetGlobal.c(Global.s.ChiTalk, 2);
                    e = EventSetGlobal.c(Global.s.LabraAlmaTalk, 2);
                    e = EventSetGlobal.c(Global.s.GoldieTalk, 2);
                    e = EventSetGlobal.c(Global.s.CrestTalk, 2);
                    e = EventSetGlobal.c(Global.s.PuddleTalk, 2);
                    e = EventSetGlobal.c(Global.s.SharpeiTalk, 2);
                    e = EventSetGlobal.c(Global.s.YorkTalk, 2);
                    e = EventSetGlobal.c(Global.s.StoneBlockSearch, 5);
                    e = EventSetGlobal.c(Global.s.ShibeTalk, 7);
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }
                
                ep = sbs5;
                {
                    var hasDolphie = new EventPage();
                    var notHasDolphie = new EventPage();

                    e = EventPageSwitch.c(Global.s.HasDolphie).AddEventPage(0, notHasDolphie).AddEventPage(1, hasDolphie);

                    ep = hasDolphie;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.None, @"You stacked the large inflatable
                                                         dolphin onto the rock thing.");
                        e = EventSetGlobal.c(Global.s.StoneBlockSearch, 6);
                        e = EventSetGlobal.c(Global.s.HasDolphie, 0);

                        var blessing2 = new EventPage();
                        e = EventPageSwitch.c(Global.s.Blessing).AddEventPage(2, blessing2);

                        ep = blessing2;
                        {
                            e = EventTextbox.c(Faces.None, @"You stacked the Famicom onto
                                                             the rock thing.");
                            e = EventSetGlobal.c(Global.s.HasFamicom, 0);
                            e = EventSetGlobal.c(Global.s.ShibeTalk, 11);
                            e = EventSetGlobal.c(Global.s.StoneBlockSearch, 7);
                        }

                        ep = hasDolphie;
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = notHasDolphie;
                    {
                        var blessing0 = new EventPage();
                        var blessing1 = new EventPage();
                        var blessing2 = new EventPage();

                        e = EventPageSwitch.c(Global.s.Blessing).AddEventPage(0, blessing0).AddEventPage(1, blessing1).AddEventPage(2, blessing2);

                        ep = blessing0;
                        {
                            e = EventPlayerMoveable.c(false);
                            e = EventTextbox.c(Faces.Shibe_uh, @"We don't have anything we can stack
                                                                 on there right now.");

                            var hasFamicom = new EventPage();
                            e = EventPageSwitch.c(Global.s.HasFamicom).AddEventPage(1, hasFamicom);

                            ep = hasFamicom;
                            {
                                e = EventSetGlobal.c(Global.s.Blessing, 1);
                            }

                            ep = blessing0;
                            e = EventTextboxClose.c;
                            e = EventPlayerMoveable.c(true);
                        }

                        ep = blessing1;
                        {
                            e = EventPlayerMoveable.c(false);
                            e = EventTextbox.c(Faces.Shibe_uh, @"We don't have anything we can stack
                                                                 on there right now.");
                            e = EventSFX.c(SFX.Pom_bark);
                            e = EventTextbox.c(Faces.Pom, @"ding dong that is wrong");
                            e = EventTextbox.c(Faces.Pom, @"we have this famicom");
                            e = EventTextbox.c(Faces.Shibe_uh, @"But that's not ours!");
                            e = EventTextbox.c(Faces.Shibe_uh, @"We're supposed to give that to Goldie.");
                            e = EventTextbox.c(Faces.None, @"You stacked the Famicom onto the
                                                             rock thing.");
                            e = EventSetGlobal.c(Global.s.GoldieTalk, 6);
                            e = EventSetGlobal.c(Global.s.StoneBlockSearch, 8);
                            e = EventSetGlobal.c(Global.s.BadEnd, 1);
                            e = EventSetGlobal.c(Global.s.ShibeTalk, 7);
                            e = EventSetGlobal.c(Global.s.HasFamicom, 0);
                            e = EventTextboxClose.c;
                            e = EventPlayerMoveable.c(true);
                        }

                        ep = blessing2;
                        {
                            e = EventPlayerMoveable.c(false);
                            e = EventTextbox.c(Faces.None, @"You stacked the Famicom onto the
                                                             rock thing.");
                            e = EventSetGlobal.c(Global.s.StoneBlockSearch, 8);
                            e = EventSetGlobal.c(Global.s.HasFamicom, 0);
                            e = EventTextboxClose.c;
                            e = EventPlayerMoveable.c(true);
                        }
                    }
                }

                ep = sbs6;
                {
                    var blessing0 = new EventPage();
                    var blessing1 = new EventPage();
                    var blessing2 = new EventPage();

                    e = EventPageSwitch.c(Global.s.Blessing).AddEventPage(0, blessing0).AddEventPage(1, blessing1).AddEventPage(2, blessing2);

                    ep = blessing0;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe_uh, @"We don't have anything we can stack
                                                                 on there right now.");

                        var hasFamicom = new EventPage();
                        e = EventPageSwitch.c(Global.s.HasFamicom).AddEventPage(1, hasFamicom);

                        ep = hasFamicom;
                        {
                            e = EventSetGlobal.c(Global.s.Blessing, 1);
                        }

                        ep = blessing0;
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = blessing1;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe_uh, @"We don't have anything we can stack
                                                                 on there right now.");
                        e = EventSFX.c(SFX.Pom_bark);
                        e = EventTextbox.c(Faces.Pom, @"ding dong that is wrong");
                        e = EventTextbox.c(Faces.Pom, @"we have this famicom");
                        e = EventTextbox.c(Faces.Shibe_uh, @"But that's not ours!");
                        e = EventTextbox.c(Faces.Shibe_uh, @"We're supposed to give that to Goldie.");
                        e = EventTextbox.c(Faces.None, @"You stacked the Famicom onto the
                                                             rock thing.");
                        e = EventSetGlobal.c(Global.s.GoldieTalk, 6);
                        e = EventSetGlobal.c(Global.s.StoneBlockSearch, 7);
                        e = EventSetGlobal.c(Global.s.BadEnd, 1);
                        e = EventSetGlobal.c(Global.s.ShibeTalk, 11);
                        e = EventSetGlobal.c(Global.s.HasFamicom, 0);
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = blessing2;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.None, @"You stacked the Famicom onto the
                                                             rock thing.");
                        e = EventSetGlobal.c(Global.s.StoneBlockSearch, 7);
                        e = EventSetGlobal.c(Global.s.HasFamicom, 0);
                        e = EventSetGlobal.c(Global.s.ShibeTalk, 11);
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }

                ep = sbs7;
                {
                    var husInParty = new EventPage();
                    var chiInParty = new EventPage();
                    var nobodyInPartyYet = new EventPage();

                    e = EventPageSwitch.c(Global.s.ExtraParkPartyMember).AddEventPage(0, nobodyInPartyYet).AddEventPage(1, husInParty).AddEventPage(2, chiInParty);

                    ep = nobodyInPartyYet;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe, @"Alright, let's--").SwitchSides;
                        e = EventShake.c(5, 5, .2f).Wait;
                        e = EventSFX.c(SFX.fire8);
                        e = EventTextbox.c(Faces.Sherman, @"You two over there!");
                        e = EventShake.c(5, 5, .2f).Wait;
                        e = EventSFX.c(SFX.Medium_Dog1);
                        e = EventTextbox.c(Faces.Shibe_nervous, @"Ahhh!!!").SwitchSides;
                        e = EventSFX.c(SFX.Pom_bark);
                        e = EventShake.c(5, 5, .2f).Wait;
                        e = EventTextbox.c(Faces.Pom, @"fuk da popo");
                        e = EventTextbox.c(Faces.Pom, @"cant tell me what 2 do");
                        e = EventTextbox.c(Faces.Pom, @"z - snap");
                        e = EventShake.c(5, 5, .2f).Wait;
                        e = EventSFX.c(SFX.fire8);
                        e = EventTextbox.c(Faces.Sherman, @"Stop!");
                        e = EventSFX.c(SFX.Pom_bark);
                        e = EventTextbox.c(Faces.Pom, @"adios bitches");
                        e = EventSetGlobal.c(Global.s.ShibeTalk, 12);
                        e = EventFade.c(.4f);
                        e = EventTPPlayer.c(new Vector2(49.5f, -13.5f)).instantTeleport;
                        e = EventMovePlayer.c(Up);
                        e = EventSetFacing.c(NPC.Pom, SpriteDir.Up);
                        e = EventSetFacing.c(NPC.Shibe, SpriteDir.Up);
                        e = EventFade.c(-.4f);
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = husInParty;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Hus, @"Come to think of it...");
                        e = EventTextbox.c(Faces.Hus, @"Pom, how did you manage to climb
                                                        over the fence while holding your
                                                        laptop like that?");
                        e = EventTextbox.c(Faces.Pom, @"i didnt");
                        e = EventTextbox.c(Faces.Pom, @"shibe lifted me by the scruff of da
                                                        neck with his mouth and climbed over");
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"I thought my jaw was going to snap
                                                                  off!");
                        e = EventTextbox.c(Faces.Hus, @"Though since this is heaven, even if
                                                        it did snap off, you'd probably be fine.");
                        e = EventTextbox.c(Faces.Shibe_nervous, @"Please don't say things like that...");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = chiInParty;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe_uh, @"Thank goodness we don't have to
                                                             climb in like that again...");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }

                ep = sbs8;
                {
                    var hasDolphie = new EventPage();
                    var notHasDolphie = new EventPage();

                    e = EventPageSwitch.c(Global.s.HasDolphie).AddEventPage(0, notHasDolphie).AddEventPage(1, hasDolphie);

                    ep = hasDolphie;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventSetGlobal.c(Global.s.StoneBlockSearch, 9);
                        e = EventTextbox.c(Faces.None, @"You stacked the large inflatable
                                                         dolphin onto the rock thing.");
                        e = EventSetGlobal.c(Global.s.ShibeTalk, 11);
                        e = EventSetGlobal.c(Global.s.HasDolphie, 0);
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = notHasDolphie;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe, @"We don't have anything we can stack
                                                          on there right now.");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }

                ep = sbs9;
                {
                    e = EventPageExecute.c(sbs7);
                }
            }

            ep = parkFixed;
            {
                var shibeInParty = new EventPage();
                var shibeNotInParty = new EventPage();

                e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

                ep = shibeNotInParty;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = shibeInParty;
                {
                    var silentTreatment = new EventPage();
                    var notSilentTreatment = new EventPage();

                    e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, notSilentTreatment).AddEventPage(1, silentTreatment);

                    ep = silentTreatment;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Pom, @"hey shibe");
                        e = EventTextbox.c(Faces.Shibe_uh, @"...");
                        e = EventTextbox.c(Faces.Pom, @"...");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = notSilentTreatment;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe_uh, @"Thank goodness we don't have to
                                                             climb in like that again...");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }
            }
        }

        //Fence
        NewEP("f465274e-a559-487a-9322-e3d4c4900899");
        {
            var sneaking = new EventPage();

            e = EventPageSwitch.c(Global.s.ParkState).AddEventPage(0, sneaking);

            ep = sneaking;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe_uh, @"We shouldn't let Sherman see us...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //ShermanBlock
        NewEP("044111d1-401e-4169-89ed-72c1e55b573f");
        {
            e = EventPlayerMoveable.c(false);
            e = EventTextbox.c(Faces.Sherman, @"It's dangerous in there!
                                                You can't go in.");
            e = EventTextboxClose.c;
            e = EventPlayerMoveable.c(true);
        }

        //Too close to sherman
        NewEP("397b4952-b0e6-4f75-8778-fad83eabfc57");
        {
            e = EventPlayerMoveable.c(false);
            e = EventTextbox.c(Faces.Shibe, @"We shouldn't let Sherman see us...");
            e = EventTextboxClose.c;
            e = EventPlayerMoveable.c(true);
        }

        //ExitParkTrigger
        NewEP("e9b15aa0-1c6e-43dd-bd0e-595bfce4484c");
        {
            var shermanTalk0 = new EventPage();

            e = EventPageSwitch.c(Global.s.ShermanTalk).AddEventPage(0, shermanTalk0);

            ep = shermanTalk0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Sherman, @"It's you two troublemakers from
                                                    earlier!");
                e = EventTextbox.c(Faces.Pom, @"yea we rebels");
                e = EventTextbox.c(Faces.Pom, @"wanna join our gang");
                e = EventTextbox.c(Faces.Hus, @"We're a gang now?");
                e = EventTextbox.c(Faces.Sherman, @"Hey, Hus! You're with them?");
                e = EventTextbox.c(Faces.Hus, @"Yup. We're helping each other out a
                                                bit.");
                e = EventTextbox.c(Faces.Sherman, @"So even these delinquents are good
                                                    for something, huh?");
                e = EventTextbox.c(Faces.Sherman, @"Alright, come on through then.");
                e = EventSetGlobal.c(Global.s.ShibeTalk, 16);
                e = EventSetGlobal.c(Global.s.ShermanTalk, 1);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Disallow Leaving to Town
        NewEP("acb59846-a506-4f2d-97cf-ad5ec0c0913c");
        {
            var hasHus = new EventPage();
            var hasChi = new EventPage();

            e = EventPageSwitch.c(Global.s.ExtraParkPartyMember).AddEventPage(1, hasHus).AddEventPage(2, hasChi);

            ep = hasHus;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"r u an old man?????");
                e = EventTextbox.c(Faces.Pom, @"did u already furget that we're looking
                                                4 da smallest doge");
                e = EventTextbox.c(Faces.Pom, @"that would b chi if u need it spelled
                                                out 4 u");
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Shibe, @"Wasn't it your idea to go this way in
                                                  the first place?!");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = hasChi;
            {
                e = EventPlayerMoveable.c(false);
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"where r we going???");
                e = EventTextbox.c(Faces.Pom, @"da park isnt that way!!!");
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventTextbox.c(Faces.Shibe_annoyed, @"I'm following you!");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"Stop trying to blame your bad sense
                                                          of direction on me!!!");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Disallow Leaving to Observatory
        NewEP("1cf09f7c-b763-43d5-92d3-6e3476aafb6b");
        {
            var hasHus = new EventPage();
            var hasChi = new EventPage();

            e = EventPageSwitch.c(Global.s.ExtraParkPartyMember).AddEventPage(1, hasHus).AddEventPage(2, hasChi);

            ep = hasHus;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Hus, @"Hey, where are you headed?");
                e = EventTextbox.c(Faces.Shibe_uh, @"Oh...I just thought I'd go watch Master
                                                     for a little bit.").SwitchSides;
                e = EventTextbox.c(Faces.Hus, @"''Master''?");
                e = EventTextbox.c(Faces.Pom, @"that's what he calls our owner");
                e = EventTextbox.c(Faces.Pom, @"I swear 2 dog
                                                shibe is such a goody 2 shoes");
                e = EventTextbox.c(Faces.Hus, @"You must really love that ''master'' of
                                                yours, huh?");
                e = EventTextbox.c(Faces.Hus, @"I'm a little jealous.");
                e = EventTextbox.c(Faces.Shibe_uh, @"J-j-jealous...?").SwitchSides;
                e = EventTextbox.c(Faces.Pom, @"gay");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = hasChi;
            {
                e = EventPlayerMoveable.c(false);
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"where r we going???");
                e = EventTextbox.c(Faces.Pom, @"da park isnt that way!!!");
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventTextbox.c(Faces.Shibe_annoyed, @"I'm following you!");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"Stop trying to blame your bad sense
                                                          of direction on me!!!");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //FinishedParkTrigger
        NewEP("ee13f56a-5333-4780-a1d0-7ed3746698f1");
        {
            e = EventPlayerMoveable.c(false);
            e = EventTextbox.c(Faces.Pom, @"theres a time and place 4 everything");
            e = EventTextbox.c(Faces.Pom, @"but not now");
            e = EventTextboxClose.c;
            e = EventPlayerMoveable.c(true);
        }

        #endregion

        #region Frisbee Machine

        //Dust Tunnel
        NewEP("2a326601-4daf-49f0-a5fe-1b1b5ba9db21");
        {
            var machineChecked = new EventPage();
            var machineNotChecked = new EventPage();

            e = EventPageSwitch.c(Global.s.MachineChecked).AddEventPage(0, machineNotChecked).AddEventPage(1, machineChecked);

            ep = machineNotChecked;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"holy shi-tzu");
                e = EventTextbox.c(Faces.Pom, @"this dust is so old that it's solidified");
                e = EventTextbox.c(Faces.Pom, @"im not small enough 2 worm my way
                                            through");
                e = EventTextbox.c(Faces.Pom, @"theres a control panel looking thingy
                                            over there");
                e = EventTextbox.c(Faces.Pom, @"guess theres nothing 2 do but turn
                                            back 4 now");
                e = EventSetGlobal.c(Global.s.SharpeiTalk, 3);
                e = EventSetGlobal.c(Global.s.MachineChecked, 1);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = machineChecked;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"i should report back 2 hus and shibe");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Dust Bunny
        NewEP("27e8f9f6-b528-441c-816a-6969d6a03c79");
        {
            var notSeenDustBunny = new EventPage();

            e = EventPageSwitch.c(Global.s.DustBunny).AddEventPage(0, notSeenDustBunny);

            ep = notSeenDustBunny;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"it's a dust bunny");
                e = EventTextbox.c(Faces.Pom, @"looks more like a dust turd");
                e = EventTextbox.c(Faces.Pom, @"speaking of turd");
                e = EventTextbox.c(Faces.Pom, @"don't u think shibe's tail is shaped a
                                                lot like one");
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventSFX.c(SFX.Pom_bark);
                e = EventSFX.c(SFX.fire8);
                e = EventTextbox.c(Faces.Pom, @"ACHOO");
                e = EventSetGlobal.c(Global.s.DustBunny, 1);
                e = EventTextboxClose.c;
                e = EventWait.c(1.5f);
                e = EventTextbox.c(Faces.Pom, @"bless me");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Exit
        NewEP("e49703ca-6e05-4b52-9eea-9c2db2c60239");
        {
            var machineChecked = new EventPage();
            var machineNotChecked = new EventPage();

            e = EventPageSwitch.c(Global.s.MachineChecked).AddEventPage(0, machineNotChecked).AddEventPage(1, machineChecked);

            ep = machineNotChecked;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"wait a minute");
                e = EventTextbox.c(Faces.Pom, @"im not done investigating here yet");
                e = EventTextbox.c(Faces.Pom, @"unlike miles edgeworth im not going 2
                                                b stopped by anything");
                e = EventTextbox.c(Faces.Pom, @"not even north american localization");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = machineChecked;
            {
                e = EventPlayerMoveable.c(false);
                e = EventFade.c(.5f);
                e = EventChangeSprite.c(PlayerSprite.None);
                e = EventSetGlobal.c(Global.s.ShibeAbleToFollow, 1);
                e = EventTPPlayer.c(new Vector2(41.5f, 13.5f), SpriteDir.Down).instantTeleport;
                e = EventMovePlayer.c(Left);
                e = EventMovePlayer.c(Left);
                e = EventMovePlayer.c(Left);
                e = EventFade.c(-.5f);

                e = EventTextbox.c(Faces.Pom, @"DRR...");
                e = EventTextbox.c(Faces.Pom, @"DRR...");
                e = EventTextbox.c(Faces.Pom, @"DRR...");
                e = EventTextbox.c(Faces.Shibe_uh, @"Why are you making weird noises?");
                e = EventChangeSprite.c(PlayerSprite.Normal);
                e = EventTextbox.c(Faces.Pom, @"i was trying 2 scare u");
                e = EventTextbox.c(Faces.Shibe_uh, @"You always scare me...");
                e = EventTextbox.c(Faces.Pom, @"wow im all gross and dusty now");
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventShake.c(5, 5, .2f);
                e = EventTextbox.c(Faces.Shibe_annoyed, @"Don't wipe your filthy paws on me!");
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventTextbox.c(Faces.Hus, @"So, did you find anything?");
                e = EventTextbox.c(Faces.Pom, @"there was a control panel in there but
                                                i couldnt reach it");
                e = EventTextbox.c(Faces.Pom, @"it would take a hella tiny doge 2 fit in
                                                there");
                e = EventTextbox.c(Faces.Hus, @"Hm...Let's try to find a dog who fits
                                                the bill, then.");
                e = EventTextbox.c(Faces.Shibe_uh, @"But, we can't climb back out of the
                                                     park the way we came in ...");
                e = EventTextbox.c(Faces.Shibe_uh, @"How are we getting out of here?");
                e = EventTextbox.c(Faces.Hus, @"Through the front door, of course!");
                e = EventTextbox.c(Faces.Hus, @"Sherman will let you guys through
                                                once he sees that you're with me.");
                e = EventTextbox.c(Faces.Shibe_uh, @"Oh, yeah...
                                                     I forgot you were on such good terms
                                                     with everyone here.");
                e = EventTextbox.c(Faces.Hus, @"You will be too, soon enough.");
                e = EventSetGlobal.c(Global.s.ChiTalk, 3);

                var goldieTalk5 = new EventPage();
                var goldieTalk6 = new EventPage();

                e = EventPageSwitch.c(Global.s.GoldieTalk).AddEventPage(5, goldieTalk5).AddEventPage(6, goldieTalk6);
                ep = goldieTalk5; { e = EventSetGlobal.c(Global.s.GoldieTalk, 8); }
                ep = goldieTalk6; { e = EventSetGlobal.c(Global.s.GoldieTalk, 7); }
                
                ep = machineChecked;
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //City Escape
        NewEP("5057f240-3e59-4d36-b33e-45da68bb8b76");
        {
            var cityEscape0 = new EventPage();
            var cityEscape1 = new EventPage();
            var cityEscape2 = new EventPage();
            var cityEscape3 = new EventPage();

            e = EventPageSwitch.c(Global.s.CityEscape).AddEventPage(0, cityEscape0).AddEventPage(1, cityEscape1).AddEventPage(2, cityEscape2).AddEventPage(3, cityEscape3);

            ep = cityEscape0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"this is where da frisbees r coming
                                                from");
                e = EventTextbox.c(Faces.Pom, @"so fast
                                                sonic would b jealous");
                e = EventSetGlobal.c(Global.s.CityEscape, 1);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = cityEscape1;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"rolling around at da speed of sound");
                e = EventTextbox.c(Faces.Pom, @"got places to go
                                                gotTA FOLLOW MY RAINBOW");
                e = EventSetGlobal.c(Global.s.CityEscape, 2);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = cityEscape2;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"FOLLOW ME");
                e = EventTextbox.c(Faces.Pom, @"SET ME FREE");
                e = EventTextbox.c(Faces.Pom, @"TRUST ME AND WE WILL ESCAPE
                                                FROM DA CITY");
                e = EventSetGlobal.c(Global.s.CityEscape, 3);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = cityEscape3;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"i should sing that song on
                                                americanine idol");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        #endregion

        #region Observatory

        NewEP("bcd40acc-69a0-497e-b78e-99a998f9563e");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeInParty;
            {
                var silentTreatment = new EventPage();
                var notSilentTreatment = new EventPage();

                e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, notSilentTreatment).AddEventPage(1, silentTreatment);

                ep = silentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"hey shibe");
                    e = EventTextbox.c(Faces.Shibe_uh, @"...");
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = notSilentTreatment;
                {
                    var observatory0 = new EventPage();
                    var observatory1 = new EventPage();

                    e = EventPageSwitch.c(Global.s.Observatory).AddEventPage(0, observatory0).AddEventPage(1, observatory1);

                    ep = observatory0;
                    {
                        var lookThroughGlass = new EventPage();
                        var dontLookThroughGlass = new EventPage(); ;

                        e = EventPlayerMoveable.c(false);
                        e = EventTextboxChoice.c.AddText("Look down through the glass?").
                                                 AddChoice("Yes", lookThroughGlass).
                                                 AddChoice("No", dontLookThroughGlass);

                        ep = lookThroughGlass;
                        {
                            e = EventTextbox.c(Faces.Shibe_uh, @"...");
                            e = EventTextbox.c(Faces.Shibe, @"It's Master!
                                                              Thank goodness, she doesn't appear
                                                              to be hurt at all!");
                            e = EventTextbox.c(Faces.Pom, @"...");
                            e = EventTextbox.c(Faces.Shibe, @"She's standing in grass in front of
                                                              some rectangular rocks in the ground
                                                              with flowers.");
                            e = EventTextbox.c(Faces.Shibe_nervous, @"Oh, no!");
                            e = EventTextbox.c(Faces.Shibe_nervous, @"Don't cry!");
                            e = EventTextbox.c(Faces.Pom, @"u dum shibe she cant hear u");
                            e = EventTextbox.c(Faces.Shibe_freaking_out, @"Please stop crying!");
                            e = EventTextbox.c(Faces.Shibe_freaking_out, @"I miss you too!");
                            e = EventTextbox.c(Faces.Pom, @"u idiot");
                            e = EventTextbox.c(Faces.Pom, @"i already said she cant hear u");
                            e = EventTextbox.c(Faces.Shibe_freaking_out, @"Uwaaaaaa!!! Master!!!");
                            e = EventTextbox.c(Faces.Pom, @"jfc");
                            e = EventSetGlobal.c(Global.s.Observatory, 1);
                            e = EventTextboxClose.c;
                            e = EventPlayerMoveable.c(true);
                        }

                        ep = dontLookThroughGlass;
                        {
                            e = EventTextboxClose.c;
                            e = EventPlayerMoveable.c(true);
                        }
                    }

                    ep = observatory1;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Pom, @"thats enough");
                        e = EventTextbox.c(Faces.Pom, @"let's go");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }
            }
        }

        #endregion

        #region Starpugs Exterior

        //wifi sign
        NewEP("8f83a21f-836d-46eb-b342-ff43403865d0");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeInParty;
            {
                var silentTreatment = new EventPage();
                var notSilentTreatment = new EventPage();

                e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, notSilentTreatment).AddEventPage(1, silentTreatment);

                ep = silentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"hey shibe");
                    e = EventTextbox.c(Faces.Shibe_uh, @"...");
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = notSilentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Shibe, @"''Free wi-fi inside.''");
                    e = EventTextbox.c(Faces.Shibe, @"This looks promising.");
                    e = EventTextbox.c(Faces.Pom, @"howl-elujah lets go");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }
            }

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        #endregion

        #region Starpugs Interior

        //Ug Counter
        NewEP("ae077145-261a-4d93-b723-9941794f70e0");
        {
            var ugTalk0 = new EventPage();
            var ugTalk1 = new EventPage();
            var ugTalk2plus = new EventPage();

            e = EventPageSwitch.c(Global.s.UgTalk).AddEventPage(0, ugTalk0, SwitchComparator.LessOrEqual).AddEventPage(1, ugTalk1).AddEventPage(2, ugTalk2plus, SwitchComparator.GreaterOrEqual);

            ep = ugTalk0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Ug, @"Welcome to Starpugs!");
                e = EventTextbox.c(Faces.Ug, @"Can I take your order?");
                e = EventTextbox.c(Faces.Pom, @"we're just here 4 da wi-fi");
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventTextbox.c(Faces.Shibe_nervous, @"So honest!").SwitchSides;
                e = EventTextbox.c(Faces.Ug, @"If you want to be here, you'll have to
                                               buy something using dog treats!");
                e = EventTextbox.c(Faces.Shibe_uh, @"Oh...but we don't have any dog treats...").SwitchSides;
                e = EventTextbox.c(Faces.Ug, @"Then don't waste my time!");
                e = EventTextbox.c(Faces.Pom, @"rude");
                e = EventSetGlobal.c(Global.s.ShibeTalk, 20);
                e = EventSetGlobal.c(Global.s.BernardTalk, 1);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = ugTalk1;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Ug, @"Welcome to Starpugs!");
                e = EventTextbox.c(Faces.Pom, @"we have da dog treats this time!");
                e = EventTextbox.c(Faces.Ug, @"What would you like to buy?");

                var mangoBoba = new EventPage();
                var vanillaMilkshake = new EventPage();
                var orangeJuice = new EventPage();
                var rootBeerFloat = new EventPage();

                e = EventTextboxChoice.c.AddChoice("Mango Boba", mangoBoba).
                                         AddChoice("Vanilla Milkshake", vanillaMilkshake).
                                         AddChoice("Orange Juice (no pulp)", orangeJuice).
                                         AddChoice("Root Beer Float", rootBeerFloat);

                ep = mangoBoba; e = EventTextbox.c(Faces.None, @"You received a mango boba.");
                ep = vanillaMilkshake; e = EventTextbox.c(Faces.None, @"You received a vanilla milkshake.");
                ep = orangeJuice; e = EventTextbox.c(Faces.None, @"You received an orange juice.");
                ep = rootBeerFloat;
                {
                    e = EventTextbox.c(Faces.None, @"You received a root beer float.");
                    e = EventSetGlobal.c(Global.s.RootBeer, 1);
                }
                
                ep = ugTalk1;

                e = EventTextboxClose.c;
                e = EventFade.c(.5f);
                e = EventTPPlayer.c(new Vector2(83.5f, -51.5f)).instantTeleport;
                e = EventWait.c(0f);
                e = EventMovePlayer.c(Left);
                e = EventSetFacing.c(NPC.Pom, SpriteDir.Right);
                e = EventSetFacing.c(NPC.Shibe, SpriteDir.Left);
                e = EventSetGlobal.c(Global.s.ShibeTalk, 25);
                e = EventSetGlobal.c(Global.s.MaltyTalk, 1);
                e = EventFade.c(-.5f);
                e = EventWait.c(1f);
                e = EventTextbox.c(Faces.Pom, @"................");
                e = EventTextbox.c(Faces.Pom, @"????????????");
                e = EventTextbox.c(Faces.Pom, @"wheres da wi-fi");
                e = EventTextbox.c(Faces.Pom, @"what the hecky");
                e = EventTextbox.c(Faces.Shibe_uh, @"You're not getting any?");
                e = EventTextbox.c(Faces.None, @"\C[1]???\C[0]
                                                 Let's get this comedy show started!");
                e = EventTextbox.c(Faces.Shibe_uh, @"Huh?");
                e = EventSetFacing.c(NPC.Pom, SpriteDir.Up);
                e = EventSetFacing.c(NPC.Shibe, SpriteDir.Up);
                e = EventTextbox.c(Faces.WittyFido, @"I'm Witty Fido!");
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.WittyFido, @"Call me Wi-Fi for short!");
                e = EventSFX.c(SFX.Rimshot);
                e = EventTextboxClose.c;
                e = EventWait.c(1f);
                e = EventTextbox.c(Faces.Shibe_nervous, @"So when the sign said ''free Wi-Fi''...");
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Shibe_nervous, @"It meant him?!");
                e = EventTextbox.c(Faces.Pom, @"O");
                e = EventTextbox.c(Faces.Pom, @"M");
                e = EventTextbox.c(Faces.Pom, @"F");
                e = EventTextbox.c(Faces.Pom, @"G");
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"U HAVE GOTTA B KEEEEEEEEDDING
                                                ME");
                e = EventTextbox.c(Faces.WittyFido, @"What's brown and sticky?");
                e = EventTextboxClose.c;
                e = EventWaitForInput.c;
                e = EventTextbox.c(Faces.WittyFido, @"A stick!");
                e = EventSFX.c(SFX.Rimshot);
                e = EventTextbox.c(Faces.Pom, @"DOG WHAT A WASTE OF TIME");
                e = EventTextbox.c(Faces.Pom, @"SHIBE WE'RE LEAVING");
                e = EventSetGlobal.c(Global.s.CorgTalk, 1);
                e = EventSetGlobal.c(Global.s.UgTalk, 2);

                var badEnd = new EventPage(); e = EventPageSwitch.c(Global.s.BadEnd).AddEventPage(1, badEnd);
                ep = badEnd; { e = EventSetGlobal.c(Global.s.CorgTalk, 3); }

                ep = ugTalk1;

                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = ugTalk2plus;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Ug, @"Welcome to Starpugs!");
                e = EventTextbox.c(Faces.Ug, @"Can I take your order?");
                e = EventTextbox.c(Faces.Pom, @"no");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Desserts
        NewEP("094765c6-c2c9-4e01-8650-acf09a9e63d9");
        {
            var shibeInParty = new EventPage();
            var shibeNotInparty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInparty).AddEventPage(1, shibeInParty);

            ep = shibeNotInparty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeInParty;
            {
                var silentTreatment = new EventPage();
                var notSilentTreatment = new EventPage();

                e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, notSilentTreatment).AddEventPage(1, silentTreatment);

                ep = notSilentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"hey shibe");
                    e = EventTextbox.c(Faces.Shibe_uh, @"...");
                    e = EventTextbox.c(Faces.Pom, @"...");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = silentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Shibe, @"There's tons of pastries and desserts
                                                      in here.");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }
            }
        }

        //Yell Boundary
        NewEP("8d9849cb-9e59-417e-9d62-6373a7728a58");
        {
            var notWatchedShow = new EventPage();

            e = EventPageSwitch.c(Global.s.UgTalk).AddEventPage(1, notWatchedShow, SwitchComparator.LessOrEqual);

            ep = notWatchedShow;
            {
                //TODO: Should this event be solid? So you can't get to the left side of the shop?
                e = EventPlayerMoveable.c(false);
                e = EventSFX.c(SFX.fire8);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Ug, @"If you're not buying something, leave!");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"RUDE");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        #endregion

        #endregion

        
        #region NPCs

        //Shibe
        NewEP("f125b5c1-a3e4-4128-8dbc-f2e06d2091bc");
        {
            var shibeTalkIs1 = new EventPage(); var shibeTalkIs3 = new EventPage();
            var shibeTalkIs4 = new EventPage(); var shibeTalkIs5 = new EventPage();
            var shibeTalkIs6 = new EventPage(); var shibeTalkIs7 = new EventPage();
            var shibeTalkIs8 = new EventPage(); var shibeTalkIs9 = new EventPage();
            var shibeTalkIs10 = new EventPage(); var shibeTalkIs11 = new EventPage();
            var shibeTalkIs12 = new EventPage(); var shibeTalkIs13 = new EventPage();
            var shibeTalkIs14 = new EventPage(); var shibeTalkIs15 = new EventPage();
            var shibeTalkIs16 = new EventPage(); var shibeTalkIs17 = new EventPage();
            var shibeTalkIs18 = new EventPage(); var shibeTalkIs19 = new EventPage();
            var shibeTalkIs20 = new EventPage(); var shibeTalkIs21 = new EventPage();
            var shibeTalkIs22 = new EventPage(); var shibeTalkIs23 = new EventPage();
            var shibeTalkIs24 = new EventPage(); var shibeTalkIs25 = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeTalk).AddEventPage(1, shibeTalkIs1).AddEventPage(3, shibeTalkIs3).AddEventPage(4, shibeTalkIs4)
                                                   .AddEventPage(5, shibeTalkIs5).AddEventPage(6, shibeTalkIs6).AddEventPage(7, shibeTalkIs7)
                                                   .AddEventPage(8, shibeTalkIs8).AddEventPage(9, shibeTalkIs9).AddEventPage(10, shibeTalkIs10)
                                                   .AddEventPage(11, shibeTalkIs11).AddEventPage(12, shibeTalkIs12).AddEventPage(13, shibeTalkIs13)
                                                   .AddEventPage(14, shibeTalkIs14).AddEventPage(15, shibeTalkIs15).AddEventPage(16, shibeTalkIs16)
                                                   .AddEventPage(17, shibeTalkIs17).AddEventPage(18, shibeTalkIs18).AddEventPage(19, shibeTalkIs19)
                                                   .AddEventPage(20, shibeTalkIs20).AddEventPage(21, shibeTalkIs21).AddEventPage(22, shibeTalkIs22)
                                                   .AddEventPage(23, shibeTalkIs23).AddEventPage(24, shibeTalkIs24).AddEventPage(25, shibeTalkIs25);

            ep = shibeTalkIs1;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe, @"Why do you have laptop with you,
                                                  always?");
                e = EventTextbox.c(Faces.Pom, @"i am a lapdog after all");
                e = EventTextbox.c(Faces.Shibe_uh, @"I'm pretty sure that's not what the
                                                     term means.");
                e = EventSetGlobal.c(Global.s.ShibeTalk, 3);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs3;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"if i dont check my facebark soon
                                                im going 2 die");
                e = EventTextbox.c(Faces.Pom, @"come on sebastian
                                                lets get going");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"My name's not Sebastian!");
                e = EventTextbox.c(Faces.Pom, @"mush");
                e = EventTextbox.c(Faces.Shibe_uh, @"Alright, alright! I get it!");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs4;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe_uh, @"I can't believe we're really dead...");
                e = EventTextbox.c(Faces.Shibe_uh, @"I thought it was strange when I
                                                     suddenly woke up here, but
                                                     still!");
                e = EventTextbox.c(Faces.Pom, @"i thought it was strange when
                                                my wi-fi was gone");
                e = EventTextbox.c(Faces.Shibe_uh, @"So, what should we do now?");
                e = EventTextbox.c(Faces.Pom, @"keep asking around about wi-fi");
                e = EventTextbox.c(Faces.Shibe_uh, @"Not a lot of dogs would know what it
                                                     is, though.");
                e = EventTextbox.c(Faces.Shibe_uh, @"If I didn't live with you, I wouldn't
                                                     have known what it was either.");
                e = EventTextbox.c(Faces.Pom, @"got any better ideas");
                e = EventTextbox.c(Faces.Shibe_uh, @"Not really...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs5;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"lets go!! 2 da cafe");
                e = EventTextbox.c(Faces.Shibe, @"Alright! All we have to do is keep
                                                  going east.");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs6;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"we'll have 2 do something about this
                                                line if we wanna pass");
                e = EventTextbox.c(Faces.Pom, @"why is life so suck");
                e = EventTextbox.c(Faces.Shibe_uh, @"Maybe if we could get into the park,
                                                     we could figure out why they're not
                                                     lettign anyone in.");
                e = EventTextbox.c(Faces.Shibe_uh, @"Sherman is blocking the entrance,
                                                     though");
                e = EventTextbox.c(Faces.Pom, @"lets kill him");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"That's not the answer!");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs7;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe, @"We need to gather things to pile
                                                  onto that stone in front of the park");
                e = EventTextbox.c(Faces.Shibe, @"Seeing how those two rude ladies in
                                                  line happened to have stuff on them...");
                e = EventTextbox.c(Faces.Pom, @"...makes u wonder if the other doges
                                                have stuff we could use too");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs8;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"we should find papi and beat da dog
                                                treats outta her");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"Don't be so eager to resort to
                                                          violent measures!");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs9;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"whats goldie going 2 think of this tho");
                e = EventTextbox.c(Faces.Shibe_uh, @"There's nothing we can do but tell her
                                                     what happened.");
                e = EventTextbox.c(Faces.Shibe, @"Honesty is the best policy!").SwitchSides;
                e = EventTextbox.c(Faces.Pom, @"when u say things like that it makes
                                                me want to throw up");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs10;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe_annoyed, @"I think we should help Crest...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs11;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe, @"We have enough stuff to scale the
                                                  fence now!").SwitchSides;
                e = EventTextbox.c(Faces.Shibe, @"Let's go!").SwitchSides;
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs12;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe, @"Let's go see what's wrong.").SwitchSides;
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs13;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe, @"Looks like we found the problem.
                                                  The frisbee throwing machine's gone
                                                  berserk!").SwitchSides;
                e = EventTextbox.c(Faces.Pom, @"there must b some way 2 fix it");
                e = EventTextbox.c(Faces.Pom, @"lets try 2 dodge all da frisbees and c
                                                what's on the other side");
                e = EventTextbox.c(Faces.Shibe, @"Be careful!
                                                  It would be bad if we both got knocked
                                                  out by those frisbees at once.");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs14;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"how did u even get in here hus");
                e = EventTextbox.c(Faces.Hus, @"Through the entrance.
                                                Sherman let me in.");
                e = EventTextbox.c(Faces.Shibe_uh, @"...So you're not a ghost..?").SwitchSides;
                e = EventTextbox.c(Faces.Hus, @"Is that what you were thinking all
                                                this time?!");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs15;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe, @"For a place that's supposed to be heaven,
                                                  there sure is a lot wrong with it.").SwitchSides;
                e = EventTextbox.c(Faces.Hus, @"Seriously. I wonder what Dog is up to
                                                these days.");
                e = EventTextbox.c(Faces.Shibe_uh, @"Dog?").SwitchSides;
                e = EventTextbox.c(Faces.Hus, @"He's something like the head honcho
                                                around here.");
                e = EventTextbox.c(Faces.Hus, @"I've never met him, but I hear that
                                                he's invincible.");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs16;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe, @"I don't recall ever joining a gang.");
                e = EventTextbox.c(Faces.Pom, @"we homies 4 life");
                e = EventTextbox.c(Faces.Pom, @"we ride together we die together");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs17;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"our theme song should b a screamo
                                                cover of love story by taylor swift");
                e = EventTextbox.c(Faces.Pom, @"then we should get black hoodies and
                                                paint skulls on them with white-out");
                e = EventTextbox.c(Faces.Hus, @"Not hardcore enough!");
                e = EventTextbox.c(Faces.Hus, @"We need temporary tattoos.");
                e = EventTextbox.c(Faces.Hus, @"Dibs on the kitty one!");
                e = EventTextbox.c(Faces.Shibe_uh, @"Aren't you two getting awfully
                                                     excited about this?").SwitchSides;
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs18;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Chi, @"I forgot to ask, but...
                                                What did you need me for?");
                e = EventTextbox.c(Faces.Pom, @"gang activities");
                e = EventTextbox.c(Faces.Pom, @"we're burying a dead body");
                e = EventTextbox.c(Faces.Pom, @"in fact that dead body is gONNA B U");
                e = EventTextbox.c(Faces.Chi_nervous, @"Oh...oh, no!
                                                        Please reconsider!");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"Pom, stop that!
                                                          You're scaring him!");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs19;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"da path 2 da cafe is finally clear");
                e = EventTextbox.c(Faces.Pom, @"googogogogogog og og");
                e = EventTextbox.c(Faces.Pom, @"gotta gio fatus");
                e = EventTextbox.c(Faces.Pom, @"gottas go fatser faster
                                                fastre fatsre fgaster fatre fatsre");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"I can't understand a single word
                                                          you're saying!");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs20;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe_uh, @"I guess I should have known better
                                                     than to expect it to be simple.");
                e = EventTextbox.c(Faces.Shibe_uh, @"We'll have to obtain some dog treats
                                                     so we can buy a drink...");
                e = EventTextbox.c(Faces.Shibe_uh, @"So that we can sit inside StarPugs...");
                e = EventTextbox.c(Faces.Shibe_uh, @"So that you can use their wi-fi.");
                e = EventTextbox.c(Faces.Pom, @"time to look for dogs to shake down
                                                for dog treats");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs21;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe_annoyed, @"Why did you accept?!");
                e = EventTextbox.c(Faces.Pom, @"we need da treats dont we");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"No matter how you look at it, this
                                                          isn't right!");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"I'm not talking to you!");
                e = EventTextbox.c(Faces.Pom, @"lol we'll c how long that lasts");
                e = EventTextbox.c(Faces.Pom, @"poopy head");
                e = EventTextbox.c(Faces.Shibe_blush, @"..................................");
                e = EventTextbox.c(Faces.Pom, @"ur tail looks like poop too");
                e = EventTextbox.c(Faces.Shibe_blush, @"..............................................................");
                e = EventSetGlobal.c(Global.s.Silent_Treatment, 1);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs22;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"hey shibe");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"......................");
                e = EventTextbox.c(Faces.Pom, @"fine b that way");
                e = EventTextbox.c(Faces.Pom, @"c if i care");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs23;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe_annoyed, @"I can't believe I messed up and talked
                                                          yo you...");
                e = EventTextbox.c(Faces.Pom, @"u do this every single time u try 2
                                                give me the silent treatment");
                e = EventTextbox.c(Faces.Pom, @"it's never going 2 work");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs24;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe_uh, @"Come on! Let's hurry to the cafe!");
                e = EventTextbox.c(Faces.Pom, @"whats this??");
                e = EventTextbox.c(Faces.Pom, @"shibe have u at last realized how
                                                vital wi-fi is 2 ur well being");
                e = EventTextbox.c(Faces.Shibe_uh, @"No, that's not it.");
                e = EventTextbox.c(Faces.Shibe_uh, @"Since this is heaven I'm not hungry or
                                                     anything, but it's still really difficult
                                                     to restrain myself from eating these
                                                     treats while holding them.");
                e = EventTextbox.c(Faces.Shibe_uh, @"I can see why they're used as currency.
                                                     They're a measure of the holder's
                                                     self-control.");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeTalkIs25;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Pom, @"i still cant fukkin believe this
                                                happened");
                e = EventTextbox.c(Faces.Shibe_uh, @"I feel really bad for you, after your
                                                     hopes got all raised like that.");
                e = EventTextbox.c(Faces.Pom, @"but i wont be broken");
                e = EventTextbox.c(Faces.Pom, @"ill persevere like a tru hero");
                e = EventTextbox.c(Faces.Shibe_uh, @"I don't know if ''hero'' is really
                                                     the right word to describe you...");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Dave Pointer in Flower Field Town
        NewEP("2c6cfa07-9274-4894-8a77-faf92b4d6b47");
        {
            var davePointer0 = new EventPage();
            var davePointer1 = new EventPage();
            var davePointer2 = new EventPage();

            e = EventPageSwitch.c(Global.s.DavePointer).AddEventPage(0, davePointer0).AddEventPage(1, davePointer1).AddEventPage(2, davePointer2);

            ep = davePointer0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.DavePointer, "Save?");
                e = EventTextbox.c(Faces.Shibe, "...").SwitchSides;
                e = EventTextbox.c(Faces.Shibe_uh, "......?").SwitchSides;
                e = EventTextbox.c(Faces.Shibe_uh, "Save what?").SwitchSides;
                e = EventTextbox.c(Faces.Shibe_uh, "The rainforest? The manatees?").SwitchSides;
                e = EventTextbox.c(Faces.Pom, "ive been waiting for this!");
                e = EventSetGlobal.c(Global.s.DavePointer, 1);
                e = EventSaveScreen.c; //temp, just automatically saves to slot 0
                e = EventTextbox.c(Faces.None, @"Automatically saved to slot 0.");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = davePointer1;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.DavePointer, "Save?");
                e = EventSaveScreen.c; //temp, just automatically saves to slot 0
                e = EventTextbox.c(Faces.None, @"Automatically saved to slot 0.");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = davePointer2;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.DavePointer, "Say V?");
                e = EventSaveScreen.c; //temp, just automatically saves to slot 0
                e = EventTextbox.c(Faces.None, @"Automatically saved to slot 0.");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Papi
        NewEP("26cb3587-4495-421c-b6ab-bcba7e90d932");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeInParty;
            {
                var papiTalk0 = new EventPage();
                var papiTalk1 = new EventPage();
                var papiTalk2 = new EventPage();
                var papiTalk3 = new EventPage();
                var papiTalk4 = new EventPage();

                e = EventPageSwitch.c(Global.s.PapiTalk).AddEventPage(0, papiTalk0).AddEventPage(1, papiTalk1).AddEventPage(2, papiTalk2).AddEventPage(3, papiTalk3).AddEventPage(4, papiTalk4);

                ep = papiTalk0;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Papi, @"Hi hi hi!");
                    e = EventTextbox.c(Faces.Papi, @"Welcome to doggy heaven!");
                    e = EventTextbox.c(Faces.Shibe, @"Thanks!").SwitchSides;
                    e = EventTextbox.c(Faces.Shibe_uh, @"...wait, what?").SwitchSides;
                    e = EventShake.c(5, 5, .2f);
                    e = EventSFX.c(SFX.Medium_Dog1);
                    e = EventTextbox.c(Faces.Shibe_nervous, @"D-d-d-doggy heaven?!").SwitchSides;
                    e = EventTextbox.c(Faces.Shibe_nervous, @"Then, that means...!").SwitchSides;
                    e = EventTextbox.c(Faces.Papi, @"You got it!");
                    e = EventShake.c(5, 5, .2f);
                    e = EventSFX.c(SFX.fire8);
                    e = EventTextbox.c(Faces.Papi, @"You're dead!");
                    e = EventTextbox.c(Faces.Shibe_nervous, @"Augh!!").SwitchSides;
                    e = EventTextbox.c(Faces.Pom, @"if this is heaven then where da wi-fi");
                    e = EventTextbox.c(Faces.Pom, @"in heaven shouldn't there b ultra
                                                    hi speed wi-fi everywhere");
                    e = EventTextbox.c(Faces.Papi, @"''Wi-fi''? What's that?");
                    e = EventTextbox.c(Faces.Pom, @"omfg");
                    e = EventTextbox.c(Faces.Papi, @"Is that a new technology?");
                    e = EventTextbox.c(Faces.Papi, @"I've been up here in heaven for a while
                                                     now, so if that's the case then I wouldn't
                                                     know anything about it!");
                    e = EventTextbox.c(Faces.Papi, @"Sorry!");
                    e = EventTextbox.c(Faces.Pom, @"u better b sorry");
                    e = EventTextbox.c(Faces.Shibe_uh, @"Don't feel too bad! It's not
                                                         exactly common knowledge for
                                                         a dog to have.").SwitchSides;
                    e = EventSetGlobal.c(Global.s.PapiTalk, 1);
                    e = EventSetGlobal.c(Global.s.ShibeTalk, 4);
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = papiTalk1;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Papi, @"I, I was a pretty tech-savvy pup
                                                     while I was still living, you know!");
                    e = EventTextbox.c(Faces.Papi, @"I was the first one on the block
                                                     to own a Famicom!!");
                    e = EventTextbox.c(Faces.Shibe_uh, @"She seems a little miffed...").SwitchSides;
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = papiTalk2;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Pom, @"hand over da dog treats");
                    e = EventTextbox.c(Faces.Papi, @"A daylight robbery?!");
                    e = EventTextbox.c(Faces.Shibe_uh, @"No, no! We're here on Goldie's behalf.").SwitchSides;
                    e = EventTextbox.c(Faces.Shibe_uh, @"She sent us here to retrieve the dog
                                                         treats you owe her.").SwitchSides;
                    e = EventTextbox.c(Faces.Papi, @"Oh...about that...");
                    e = EventTextbox.c(Faces.Papi, @"I already ate them.");
                    e = EventSFX.c(SFX.Pom_bark);
                    e = EventShake.c(5, 5, .2f);
                    e = EventTextbox.c(Faces.Pom, @"PERIOD BLOOD MICROWAVE");
                    e = EventTextbox.c(Faces.Pom, @"WHAT DO WE DO NOW");
                    e = EventTextbox.c(Faces.Papi, @"How about you give her this instead!");
                    e = EventTextbox.c(Faces.None, @"You received a Famicom.");
                    e = EventTextbox.c(Faces.Shibe_uh, @"I guess we'll have to take this back
                                                         to Goldie and explain what happened.").SwitchSides;
                    e = EventSetGlobal.c(Global.s.HasFamicom, 1);
                    e = EventSetGlobal.c(Global.s.PapiTalk, 3);
                    e = EventSetGlobal.c(Global.s.ShibeTalk, 9);
                    e = EventSetGlobal.c(Global.s.GoldieTalk, 4);
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = papiTalk3;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Shibe_uh, @"................").SwitchSides;
                    e = EventTextbox.c(Faces.Papi, @"Why are you looking at me like that?!");
                    e = EventTextbox.c(Faces.Papi, @"It's really hard not to eat those treats,
                                                     you know!");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = papiTalk4;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventSFX.c(SFX.crunching1);
                    e = EventTextbox.c(Faces.Papi, @"Crest bakes the best dog treats!");
                    e = EventTextbox.c(Faces.Pom, @"i want one");
                    e = EventTextbox.c(Faces.Pom, @"too bad im spying on her so i cant
                                                    ask her for one");
                    e = EventTextbox.c(Faces.Papi, @"What do you mean by that?");
                    e = EventTextbox.c(Faces.Pom, @"nothing");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }
            }

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Papi, "Where's shibe?");
                e = EventTextbox.c(Faces.Papi, "It's almost like you two had a fight!");
                e = EventTextbox.c(Faces.Pom, "can u not");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Sharpei
        NewEP("cbb2d128-bdf5-408b-a517-c963c42e0b74");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Sharpeii, @"I don't think Crest likes me very
                                                     much.");
                e = EventTextbox.c(Faces.Sharpeii, @"Normally I couldn't care less, but it
                                                     sucks not to get dog treats from her.");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeInParty;
            {
                var sharpeiTalk0 = new EventPage();
                var sharpeiTalk1 = new EventPage();
                var sharpeiTalk2 = new EventPage();
                var sharpeiTalk3 = new EventPage();

                e = EventPageSwitch.c(Global.s.SharpeiTalk).AddEventPage(0, sharpeiTalk0).AddEventPage(1, sharpeiTalk1).AddEventPage(2, sharpeiTalk2).AddEventPage(3, sharpeiTalk3);

                ep = sharpeiTalk0;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Shibe, @"Uh, excuse me, sir!").SwitchSides;
                    e = EventTextbox.c(Faces.Shibe, @"Would you happen to know where we
                                                      might be able to findwi-fi?").SwitchSides;
                    e = EventTextbox.c(Faces.Sharpeii, @"''Why Phi?''
                                                         What the heck are you talking about?");
                    e = EventTextbox.c(Faces.Pom, @"stares into the distance");
                    e = EventTextbox.c(Faces.Shibe_uh, @"Never mind, then...").SwitchSides;
                    e = EventSetGlobal.c(Global.s.SharpeiTalk, 1);
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = sharpeiTalk1;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Sharpeii, @"Gimme a ''P''!");
                    e = EventTextbox.c(Faces.Shibe, @"Gimme an ''I''!").SwitchSides;
                    e = EventTextbox.c(Faces.Pom, @"gimme an ''s'' and an ''s''");
                    e = EventTextbox.c(Faces.Pom, @"wat does that spell??
                                                    PISS");
                    e = EventTextbox.c(Faces.Sharpeii, @"That's not what we were trying to
                                                         spell!");
                    e = EventTextbox.c(Faces.Pom, @"what am i, psychic?");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = sharpeiTalk2;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Shibe, @"Do you have anything we might be
                                                      able to borrow?").SwitchSides;
                    e = EventTextbox.c(Faces.Sharpeii, @"That you can borrow, huh?");
                    e = EventTextbox.c(Faces.Sharpeii, @"...");
                    e = EventTextbox.c(Faces.Sharpeii, @"......");
                    e = EventTextbox.c(Faces.Sharpeii, @"...........");
                    e = EventTextbox.c(Faces.Sharpeii, @"Nope, sorry.");
                    e = EventTextbox.c(Faces.Pom, @"what was wiTH THAT
                                                    UNNECESSARILY LONG PAUSE");
                    e = EventTextbox.c(Faces.Pom, @"U MADE US WAIT FOR NOTHING");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = sharpeiTalk3;
                {
                    var toyBroken = new EventPage();
                    var toyNotBroken = sharpeiTalk1;

                    e = EventPageSwitch.c(Global.s.Rocket).AddEventPage(2, toyBroken, SwitchComparator.GreaterOrEqual).AddEventPage(1, toyNotBroken, SwitchComparator.LessOrEqual);

                    ep = toyNotBroken;
                    {
                        //This is already set above in sharpeiTalk1.
                        //If you need it to say something different for whatever reason, replace 
                        //      var toyNotBroken = sharpeiTalk1;
                        //with
                        //      var toyNotBroken = new EventPage();
                        //and then copy the events here and replace what you need to.
                    }

                    ep = toyBroken;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Sharpeii, @"Somebody broke my rocket model!");
                        e = EventTextbox.c(Faces.Shibe_nervous, @"W-w-we definitely don't know
                                                                  anything about that!").SwitchSides;
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }
            }
        }

        //York
        NewEP("489e668c-6d95-4a0c-a927-acffa10e0f00");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.York, @"I wouldn't believe what some
                                                 people throw away.");
                e = EventTextbox.c(Faces.Pom, @"believe it");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeInParty;
            {
                var machineChecked = new EventPage();
                var machineNotChecked = new EventPage();

                e = EventPageSwitch.c(Global.s.MachineChecked).AddEventPage(0, machineNotChecked).AddEventPage(1, machineChecked);

                ep = machineChecked;
                {
                    var brokeStuff = new EventPage();
                    var notBrokeStuff = new EventPage();

                    e = EventPageSwitch.c(Global.s.Rocket).AddEventPage(1, brokeStuff, SwitchComparator.GreaterOrEqual).AddEventPage(0, notBrokeStuff, SwitchComparator.LessOrEqual);

                    ep = brokeStuff;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.York, @"Someone broke my model of the
                                                         Gigantic!");
                        e = EventTextbox.c(Faces.Pom, @"oh so it wasnt the titanic");
                        e = EventTextbox.c(Faces.York, @"Huh?");
                        e = EventTextbox.c(Faces.Shibe_nervous, @"Nothing! You heard nothing!").SwitchSides;
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = notBrokeStuff;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.York, @"I love here with Grandpa.");
                        e = EventTextbox.c(Faces.Pom, @"that cranky old fart downstairs?");
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"Pom, don't be rude!").SwitchSides;
                        e = EventTextbox.c(Faces.York, @"He may be cranky at times, but he's
                                                         good on the inside!");
                        e = EventTextbox.c(Faces.York, @"He got me a root beer float once.");
                        e = EventTextbox.c(Faces.Shibe_uh, @"Just because someone got you a root
                                                             beer float doesn't prove that they're a
                                                             good person...").SwitchSides;
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }

                ep = machineNotChecked;
                {
                    var talk0 = new EventPage();
                    var talk1 = new EventPage();
                    var talk2 = new EventPage();

                    e = EventPageSwitch.c(Global.s.YorkTalk).AddEventPage(0, talk0).AddEventPage(1, talk1).AddEventPage(2, talk2);

                    ep = talk0;
                    {
                        var silentTreatment = new EventPage();
                        var notSilentTreatment = new EventPage();

                        e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, notSilentTreatment).AddEventPage(1, silentTreatment);

                        ep = silentTreatment;
                        {
                            e = EventPlayerMoveable.c(false);
                            e = EventTextbox.c(Faces.York, @"I'm really craving a root beer float
                                                             right now.");
                            e = EventTextbox.c(Faces.York, @"Too bad I don't have the treats to buy
                                                             one.");
                            e = EventTextbox.c(Faces.Pom, @"so crest doesnt like u either, huh");
                            e = EventTextboxClose.c;
                            e = EventPlayerMoveable.c(true);
                        }

                        ep = notSilentTreatment;
                        {
                            e = EventPlayerMoveable.c(false);
                            e = EventTextbox.c(Faces.Shibe, @"Do you know where we can find
                                                              wi-fi?").SwitchSides;
                            e = EventTextbox.c(Faces.York, @"''Wi-fi''...?
                                                             That sounds pretty familiar.");
                            e = EventTextbox.c(Faces.York, @"I think the cafe has it.");
                            e = EventTextbox.c(Faces.York, @"If you keep heading east, you'll see it
                                                             for sure.");
                            e = EventSFX.c(SFX.Pom_bark);
                            e = EventTextbox.c(Faces.Pom, @"ARIGATOU YOUNG DOGE");
                            e = EventTextbox.c(Faces.Pom, @"i owe u my life");
                            e = EventTextbox.c(Faces.Pom, @"i love y");
                            e = EventTextbox.c(Faces.Pom, @"ugioh");
                            e = EventSetGlobal.c(Global.s.ShibeTalk, 5);
                            e = EventSetGlobal.c(Global.s.YorkTalk, 1);
                            e = EventTextboxClose.c;
                            e = EventPlayerMoveable.c(true);
                        }
                    }

                    ep = talk1;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.York, @"I love here with Grandpa.");
                        e = EventTextbox.c(Faces.Pom, @"that cranky old fart downstairs?");
                        e = EventTextbox.c(Faces.Shibe_annoyed, @"Pom, don't be rude!").SwitchSides;
                        e = EventTextbox.c(Faces.York, @"He may be cranky at times, but he's
                                                         good on the inside!");
                        e = EventTextbox.c(Faces.York, @"He got me a root beer float once.");
                        e = EventTextbox.c(Faces.Shibe_uh, @"Just because someone got you a root
                                                             beer float doesn't prove that they're a
                                                             good person...").SwitchSides;
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }

                    ep = talk2;
                    {
                        e = EventPlayerMoveable.c(false);
                        e = EventTextbox.c(Faces.Shibe, @"Do you have anything we can borrow?").SwitchSides;
                        e = EventTextbox.c(Faces.York, @"Sorry, I can't lend any of that pile
                                                         over there.");
                        e = EventTextbox.c(Faces.York, @"That stuff is important.");
                        e = EventTextbox.c(Faces.Pom, @"IMPORTANT MY ASS");
                        e = EventTextbox.c(Faces.Pom, @"I SEE SODA CANS IN THERE");
                        e = EventTextboxClose.c;
                        e = EventPlayerMoveable.c(true);
                    }
                }
            }
        }

        //Glish
        NewEP("2047de3b-6bcc-459d-823c-ee017d3a2ba8");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Glish, @"I wonder where York gets all his
                                                  trash.");
                e = EventTextbox.c(Faces.Glish, @"I can smell that junk heap in his room
                                                  from all the way over here.");
                e = EventTextbox.c(Faces.Pom, @"trash, huh");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeInParty;
            {
                var silentTreatment = new EventPage();
                var notSilentTreatment = new EventPage();

                e = EventPageSwitch.c(Global.s.Silent_Treatment).AddEventPage(0, notSilentTreatment).AddEventPage(1, silentTreatment);

                ep = notSilentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Glish, @"This is the observatory.");
                    e = EventTextbox.c(Faces.Glish, @"If you look down through the glass,
                                                      you watch over your loved ones
                                                      going about their lives!");
                    e = EventTextbox.c(Faces.Shibe, @"That's amazing!").SwitchSides;
                    e = EventTextbox.c(Faces.Shibe_uh, @"Can you really see with the fur
                                                         over your eyes like that, though?").SwitchSides;
                    e = EventTextbox.c(Faces.Glish, @"Of course!");
                    e = EventTextbox.c(Faces.Glish, @"The fur does keep poking me in
                                                      the eyes, though.");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = silentTreatment;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Glish, @"I smell dog treats in the distance!");
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }
            }
        }

        //Ug
        NewEP("61e36259-6e72-4182-a7a2-f9f1ee8fb8df");
        {
            e = EventPlayerMoveable.c(false);
            e = EventTextbox.c(Faces.Ug, @"You're not supposed to be back here!");
            e = EventTextboxClose.c;
            e = EventPlayerMoveable.c(true);
        }

        //Bold
        NewEP("3a207469-bbbd-445c-a4b8-09a81d5ecfcb");
        {
            var shibeInParty = new EventPage();
            var shibeNotInParty = new EventPage();

            e = EventPageSwitch.c(Global.s.ShibeInParty).AddEventPage(0, shibeNotInParty).AddEventPage(1, shibeInParty);

            ep = shibeNotInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Bold, @"I wonder what the world would be
                                                 like if I were dog.");
                e = EventTextbox.c(Faces.Pom, @"hell");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = shibeInParty;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Bold, @"Don't you think it'd be great if you
                                                 turned on the tap and orange juice 
                                                 came out?");
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Shibe_nervous, @"He just suddenly said something
                                                          really stupid!").SwitchSides;
                e = EventTextbox.c(Faces.Pom, @"ikr");
                e = EventTextbox.c(Faces.Pom, @"he didnt specify with or without pulp");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Witty Fido
        NewEP("9fef999e-0bcd-486d-bc24-391fe51b3848");
        {
            var wittyFidoTalk0 = new EventPage();
            var wittyFidoTalk1 = new EventPage();
            var wittyFidoTalk2 = new EventPage();
            var wittyFidoTalk3 = new EventPage();

            e = EventPageSwitch.c(Global.s.WittyFidoTalk).AddEventPage(0, wittyFidoTalk0).AddEventPage(1, wittyFidoTalk1).AddEventPage(2, wittyFidoTalk2).AddEventPage(3, wittyFidoTalk3);

            ep = wittyFidoTalk0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.WittyFido, @"What kind of dog will laugh at any
                                                      joke?");
                e = EventTextboxClose.c;
                e = EventWaitForInput.c;
                e = EventTextbox.c(Faces.WittyFido, @"A Chi-ha-ha!");
                e = EventSFX.c(SFX.Rimshot);
                e = EventSetGlobal.c(Global.s.WittyFidoTalk, 1);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = wittyFidoTalk1;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.WittyFido, @"Why are Dalmatians no good at
                                                      ''Hide and Seek''?");
                e = EventTextboxClose.c;
                e = EventWaitForInput.c;
                e = EventTextbox.c(Faces.WittyFido, @"They're always spotted!");
                e = EventSFX.c(SFX.Rimshot);
                e = EventSetGlobal.c(Global.s.WittyFidoTalk, 2);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = wittyFidoTalk2;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.WittyFido, @"Why did the man bring his dog to the
                                                      railroad station?");
                e = EventTextboxClose.c;
                e = EventWaitForInput.c;
                e = EventTextbox.c(Faces.WittyFido, @"Because he wanted to ''train'' him!");
                e = EventSFX.c(SFX.Rimshot);
                e = EventSetGlobal.c(Global.s.WittyFidoTalk, 3);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = wittyFidoTalk3;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.WittyFido, @"That's all I have for today.");
                e = EventTextbox.c(Faces.WittyFido, @"Come back tomorrow for more jokes!");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Chi
        NewEP("3e289b6f-9e2d-41a1-8c65-c2232c349ab4");
        {
            var chiTalk0 = new EventPage();
            var chiTalk1 = new EventPage();
            var chiTalk2 = new EventPage();
            var chiTalk3 = new EventPage();

            e = EventPageSwitch.c(Global.s.ChiTalk).AddEventPage(0, chiTalk0).AddEventPage(1, chiTalk1).AddEventPage(2, chiTalk2).AddEventPage(3, chiTalk3);

            ep = chiTalk0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Chi, @"I can't wait to go to the park!");
                e = EventTextbox.c(Faces.Chi, @"I'm going to train hard and become
                                                stronger.");
                e = EventTextbox.c(Faces.Pom, @"good luck with that");
                e = EventSetGlobal.c(Global.s.StoneBlockSearch, 1).Add;
                e = EventSetGlobal.c(Global.s.ChiTalk, 1);
                e = EventTextboxClose.c;
                e = EventSetFacing.c(NPC.Chi, SpriteDir.Up);
                e = EventPlayerMoveable.c(true);
            }

            ep = chiTalk1;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Chi, @"I can't wait to go to the park!");
                e = EventTextbox.c(Faces.Chi, @"I'm going to train hard and become
                                                stronger.");
                e = EventTextbox.c(Faces.Pom, @"good luck with that");
                e = EventTextboxClose.c;
                e = EventSetFacing.c(NPC.Chi, SpriteDir.Up);
                e = EventPlayerMoveable.c(true);
            }

            ep = chiTalk2;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe, @"Have anything we might be able to
                                                  borrow?").SwitchSides;
                e = EventTextbox.c(Faces.Chi_nervous, @"No...I'm sorry...");
                e = EventTextbox.c(Faces.Shibe_uh, @"You don't need to apologize!").SwitchSides;
                e = EventTextboxClose.c;
                e = EventSetFacing.c(NPC.Chi, SpriteDir.Up);
                e = EventPlayerMoveable.c(true);
            }

            ep = chiTalk3;
            {
                //TODO: chiTalk3 - Park Copy
            }
        }

        //Alma and Labra
        NewEP("736075f7-3c6a-4887-b68b-b851873d74bd");
        {
            var labraAlmaTalk0 = new EventPage();
            var labraAlmaTalk1 = new EventPage();
            var labraAlmaTalk2 = new EventPage();

            e = EventPageSwitch.c(Global.s.LabraAlmaTalk).AddEventPage(0, labraAlmaTalk0).AddEventPage(1, labraAlmaTalk1).AddEventPage(2, labraAlmaTalk2);

            ep = labraAlmaTalk0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventSetFacing.c(NPC.Labra, SpriteDir.Up);
                e = EventSetFacing.c(NPC.Alma, SpriteDir.Up);
                e = EventTextbox.c(Faces.Shibe, @"Do you mind moving aside a little?").SwitchSides;
                e = EventTextbox.c(Faces.Shibe, @"We're trying to cross that bridge
                                                  behind you.").SwitchSides;
                e = EventTextbox.c(Faces.Labra, @"No can do.");
                e = EventTextbox.c(Faces.Alma, @"We've been in this line for an awful
                                                 long time now, and it'd be simply
                                                 terrierable if we lost our place.");
                e = EventTextbox.c(Faces.Labra, @"Here, you can have these old Barron's
                                                  SAT books as our apology.");
                e = EventTextbox.c(Faces.Shibe_uh, @"Wait, we don't want these.").SwitchSides;
                e = EventTextbox.c(Faces.Labra, @"Alma, isn't the weather today
                                                  splendid?");
                e = EventTextbox.c(Faces.Alma, @"Not a cloud in the sky, as usual!");
                e = EventTextbox.c(Faces.Alma, @"Discounting the one we're standing
                                                 on, of course.");
                e = EventTextbox.c(Faces.Pom, @"theyre ignoring u");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"They just unloaded a bunch of crap
                                                          they don't want on us...").SwitchSides;
                e = EventSetGlobal.c(Global.s.StoneBlockSearch, 1).Add;
                e = EventSetGlobal.c(Global.s.LabraAlmaTalk, 1);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = labraAlmaTalk1;
            {
                e = EventPlayerMoveable.c(false);
                e = EventSetFacing.c(NPC.Labra, SpriteDir.Up);
                e = EventSetFacing.c(NPC.Alma, SpriteDir.Up);
                e = EventTextbox.c(Faces.Shibe_uh, @"Here, you can have your books back.").SwitchSides;
                e = EventTextbox.c(Faces.Alma, @"What's this?");
                e = EventTextbox.c(Faces.Alma, @"Labra, I cannot hear anything!");
                e = EventTextbox.c(Faces.Labra, @"Oh, no! The rapid onset of old age
                                                  must be taking its toll!");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"Hey!").SwitchSides;
                e = EventTextbox.c(Faces.Alma, @"I hear a faint buzzing noise in my
                                                 left ear!");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"RRRGH!").SwitchSides;
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = labraAlmaTalk2;
            {
                e = EventPlayerMoveable.c(false);
                e = EventSetFacing.c(NPC.Labra, SpriteDir.Up);
                e = EventSetFacing.c(NPC.Alma, SpriteDir.Up);
                e = EventTextbox.c(Faces.Shibe_uh, @"Hey...").SwitchSides;
                e = EventTextbox.c(Faces.Alma, @"Labra, I simply cannot wait to catch
                                                 frisbees in the park!");
                e = EventTextbox.c(Faces.Labra, @"Me neither! That feeling of absolute bliss
                                                  when you make a jumping catch...");
                e = EventTextbox.c(Faces.Labra, @"It makes waiting in line so worth it!");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"For some reason, they're still
                                                          ignoring me...").SwitchSides;
                e = EventTextbox.c(Faces.Pom, @"maybe they think u came 2 return the
                                                books 2 them");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Goldie
        NewEP("a0d2b46a-4e98-474c-b5d1-e01a8cdf9ef9");
        {
            var goldieTalk0 = new EventPage();
            var goldieTalk1 = new EventPage(); var goldieTalk2 = new EventPage();
            var goldieTalk3 = new EventPage(); var goldieTalk4 = new EventPage();
            var goldieTalk5 = new EventPage(); var goldieTalk6 = new EventPage();
            var goldieTalk7 = new EventPage(); var goldieTalk8 = new EventPage();

            e = EventPageSwitch.c(Global.s.GoldieTalk).AddEventPage(0, goldieTalk0).AddEventPage(1, goldieTalk1).AddEventPage(2, goldieTalk2).AddEventPage(3, goldieTalk3).AddEventPage(4, goldieTalk4).AddEventPage(5, goldieTalk5).AddEventPage(6, goldieTalk6).AddEventPage(7, goldieTalk7).AddEventPage(8, goldieTalk8);

            ep = goldieTalk0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Goldie, @"This line to the park is moving a lot
                                                   more slowly than usual.");
                e = EventTextbox.c(Faces.Shibe_uh, @"To be more precise, it's moving so
                                                     slowly that it's not moving at all.").SwitchSides;
                e = EventSetGlobal.c(Global.s.StoneBlockSearch, 1).Add;
                e = EventSetGlobal.c(Global.s.GoldieTalk, 1);
                e = EventSetFacing.c(NPC.Goldie, SpriteDir.Up);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = goldieTalk1;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Goldie, @"This line to the park is moving a lot
                                                   more slowly than usual.");
                e = EventTextbox.c(Faces.Shibe_uh, @"To be more precise, it's moving so
                                                     slowly that it's not moving at all.").SwitchSides;
                e = EventSetFacing.c(NPC.Goldie, SpriteDir.Up);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = goldieTalk2;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe, @"Do you have anything we might be
                                                  able to borrow?").SwitchSides;
                e = EventTextbox.c(Faces.Goldie, @"Actually...
                                                   I happen to have this giant potted
                                                   cactus on me right now!");
                e = EventTextbox.c(Faces.Shibe_uh, @"How do yo just ''happen'' to have
                                                     something like that with you?!").SwitchSides;
                e = EventTextbox.c(Faces.Shibe_uh, @"And it's so spiky...").SwitchSides;
                e = EventTextbox.c(Faces.Pom, @"thats ok");
                e = EventTextbox.c(Faces.Pom, @"hand it over");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"Pom!").SwitchSides;
                e = EventTextbox.c(Faces.Pom, @"...pls");
                e = EventTextbox.c(Faces.Goldie, @"You're strangers, though...");
                e = EventTextbox.c(Faces.Goldie, @"How do I know if I can trust you two
                                                   with it?");
                e = EventTextbox.c(Faces.Shibe_uh, @"Doesn't the fact that we're in heaven
                                                     prove that we're good dogs?").SwitchSides;
                e = EventTextbox.c(Faces.Goldie, @"There's no such thing as a bad dog,
                                                   only bad owners and bad upbringings.");
                e = EventTextbox.c(Faces.Goldie, @"So, every dog ends up here,
                                                   regardless of whether they turned out
                                                   to be trustworthy or not.");
                e = EventTextbox.c(Faces.Pom, @"how do we get u 2 trust us then");
                e = EventTextbox.c(Faces.Goldie, @"How about you run an errand for me?");
                e = EventTextbox.c(Faces.Goldie, @"Do you know Papi?
                                                   She owes me a few dog treats.");
                e = EventTextbox.c(Faces.Goldie, @"Can you ask her for them for me?");
                e = EventTextbox.c(Faces.Shibe, @"We'll do our best!").SwitchSides;
                e = EventSetGlobal.c(Global.s.ShibeTalk, 8);
                e = EventSetGlobal.c(Global.s.GoldieTalk, 3);
                e = EventSetGlobal.c(Global.s.PapiTalk, 2);
                e = EventSetFacing.c(NPC.Goldie, SpriteDir.Up);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = goldieTalk3;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Goldie, @"Have you asked Papi about the treats
                                                   yet?");
                e = EventTextbox.c(Faces.Pom, @"nope");
                e = EventTextbox.c(Faces.Goldie, @"If you keep going west the way you
                                                   came for a while, you should see her.");
                e = EventSetFacing.c(NPC.Goldie, SpriteDir.Up);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = goldieTalk4;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Goldie, @"You're back!");
                e = EventTextbox.c(Faces.Goldie, @"Where are the treats?");
                e = EventTextbox.c(Faces.Shibe_uh, @"About that...").SwitchSides;
                e = EventTextbox.c(Faces.Shibe_uh, @"Papi told us she'd eaten them all.").SwitchSides;
                e = EventTextbox.c(Faces.Shibe_uh, @"She gave us this thing instead.").SwitchSides;
                e = EventTextbox.c(Faces.None, @"You gave Goldie the Famicom.");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Pom, @"ITS NOT OUR FAULT HONEST 2 DOG");
                e = EventTextbox.c(Faces.Pom, @"TASUKETE PLS GIVE US THE GIANT
                                                CACTUS");
                e = EventTextbox.c(Faces.Goldie, @"Calm down.");
                e = EventTextbox.c(Faces.Goldie, @"I was testing you two, and you passed
                                                   with flying colors.");
                e = EventTextbox.c(Faces.Shibe_uh, @"We did?").SwitchSides;
                e = EventTextbox.c(Faces.Goldie, @"Knowing Papi, it would have been
                                                   strange if you really did come back
                                                   with dog treats.");
                e = EventTextbox.c(Faces.Shibe_uh, @"But what kind of test is that?").SwitchSides;
                e = EventTextbox.c(Faces.Shibe_uh, @"There's no way we could have.").SwitchSides;
                e = EventTextbox.c(Faces.Goldie, @"No, of course not.");
                e = EventTextbox.c(Faces.Goldie, @"The test was about whether you'd
                                                   come back to me with the Famicom.");
                e = EventTextbox.c(Faces.Shibe_uh, @"Eh?").SwitchSides;
                e = EventTextbox.c(Faces.Goldie, @"I can see you two stacking stuff on
                                                   that rock thing over there, you know.");
                e = EventTextbox.c(Faces.Goldie, @"That's why you want my potted
                                                   cactus, correct?");
                e = EventTextbox.c(Faces.Shibe_uh, @"That's right.").SwitchSides;
                e = EventTextbox.c(Faces.Goldie, @"But why didn't you just use the
                                                   Famicom?");
                e = EventTextbox.c(Faces.Goldie, @"The bottom is pretty flat and way
                                                   better for stacking than a cactus is.");
                e = EventTextbox.c(Faces.Shibe_uh, @"...!").SwitchSides;
                e = EventTextbox.c(Faces.Shibe_uh, @"I didn't even think about using it...").SwitchSides;
                e = EventTextbox.c(Faces.Goldie, @"You were so determined to make me
                                                   trust you that you were totally
                                                   distracted from your original goal.");
                e = EventTextbox.c(Faces.Goldie, @"Honestly, that's kind of adorable.");
                e = EventTextbox.c(Faces.Pom, @"oh stahp it u");
                e = EventTextbox.c(Faces.Goldie, @"Here, you can have the Famicom.");
                e = EventTextbox.c(Faces.None, @"You received a Famicom.");
                e = EventTextbox.c(Faces.Goldie, @"Now that I think about it, you would
                                                   have ended up with the Famicom
                                                   either way.");
                e = EventTextbox.c(Faces.Goldie, @"But this method has the extra bonus
                                                   of me trusting you.");
                e = EventTextbox.c(Faces.Goldie, @"I like to think that counts for
                                                   something.");
                e = EventTextbox.c(Faces.Shibe, @"It does! Thanks.").SwitchSides;
                e = EventSetGlobal.c(Global.s.GoldieTalk, 5);
                e = EventSetGlobal.c(Global.s.Blessing, 2);

                var sbs6 = new EventPage();
                var notSbs6 = new EventPage();

                e = EventPageSwitch.c(Global.s.StoneBlockSearch).AddEventPage(6, sbs6).AddEventPage(6, notSbs6, SwitchComparator.Less).AddEventPage(6, notSbs6, SwitchComparator.Greater);
                ep = sbs6; { e = EventSetGlobal.c(Global.s.ShibeTalk, 11); }

                ep = notSbs6;
                {
                    var dolphiePossessed = new EventPage();
                    var notDolphiePossessed = new EventPage();

                    e = EventPageSwitch.c(Global.s.HasDolphie).AddEventPage(0, notDolphiePossessed).AddEventPage(1, dolphiePossessed);

                    ep = dolphiePossessed; { e = EventSetGlobal.c(Global.s.ShibeTalk, 11); }
                    ep = notDolphiePossessed; { e = EventSetGlobal.c(Global.s.ShibeTalk, 7); }
                }

                ep = goldieTalk4;
                e = EventSetFacing.c(NPC.Goldie, SpriteDir.Up);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = goldieTalk5;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Goldie, @"Good luck getting in.");
                e = EventSetFacing.c(NPC.Goldie, SpriteDir.Up);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = goldieTalk6;
            {
                e = EventPlayerMoveable.c(false);
                e = EventSetFacing.c(NPC.Goldie, SpriteDir.Up);
                e = EventTextbox.c(Faces.Pom, @"we're back");
                e = EventTextbox.c(Faces.Goldie, @"I don't really want to talk to you.");
                e = EventTextbox.c(Faces.Pom, @"wow whats her problem");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = goldieTalk7;
            {
                e = EventPlayerMoveable.c(false);
                e = EventSetFacing.c(NPC.Goldie, SpriteDir.Up);
                e = EventTextbox.c(Faces.Goldie, @"I don't really want to talk to you.");
                e = EventTextbox.c(Faces.Pom, @"wow whats her problem");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = goldieTalk8;
            {
                var husInParty = new EventPage();
                var chiInParty = new EventPage();

                e = EventPageSwitch.c(Global.s.ExtraParkPartyMember).AddEventPage(1, husInParty).AddEventPage(2, chiInParty);

                ep = husInParty;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Hus, @"I don't know if you've seen yet, but
                                                    those blue and white flowers you
                                                    planted...");
                    e = EventTextbox.c(Faces.Goldie, @"Uh huh, go on...");
                    e = EventTextbox.c(Faces.Hus, @"Two of them are getting pretty ridiculous.");
                    e = EventTextbox.c(Faces.Hus, @"At the rate they're growing, they might
                                                    end up poking up through the clouds
                                                    in human heaven.");
                    e = EventTextbox.c(Faces.Goldie, @"Aw, shucks!");
                    e = EventTextbox.c(Faces.Goldie, @"They were just seedlings last time I
                                                       checked...");
                    e = EventTextbox.c(Faces.Shibe_uh, @"Just how long have you been in this line?!").SwitchSides;
                    e = EventSetFacing.c(NPC.Goldie, SpriteDir.Up);
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }

                ep = chiInParty;
                {
                    e = EventPlayerMoveable.c(false);
                    e = EventTextbox.c(Faces.Goldie, @"Good luck fixing the machine.");
                    e = EventSetFacing.c(NPC.Goldie, SpriteDir.Up);
                    e = EventTextboxClose.c;
                    e = EventPlayerMoveable.c(true);
                }
            }
        }

        //Puddle
        NewEP("c39932ac-a091-4893-b80f-da523fcdc67f");
        {
            var puddleTalk0 = new EventPage();
            var puddleTalk3 = new EventPage();
            var puddleTalk4 = new EventPage();

            e = EventPageSwitch.c(Global.s.PuddleTalk).AddEventPage(0, puddleTalk0).AddEventPage(3, puddleTalk3).AddEventPage(4, puddleTalk4);

            ep = puddleTalk0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Puddle, @"You're still wearing your collar, even
                                                   up here in heaven!");
                e = EventTextbox.c(Faces.Shibe_uh, @"Why wouldn't I be wearing it?").SwitchSides;
                e = EventTextbox.c(Faces.Shibe, @"It's like a badge of honor!").SwitchSides;
                e = EventTextbox.c(Faces.Puddle, @"You're really loyal to your owner, huh?");
                e = EventTextbox.c(Faces.Puddle, @"What a namby-pamby goody-goody!");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"A what?!").SwitchSides;
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = puddleTalk3;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Puddle, @"It's name is Dolphie.");
                e = EventTextbox.c(Faces.Pom, @"so lame");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = puddleTalk4;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Puddle, @"When I was alive, I always wondered
                                                   how the kitchen cupboard would never
                                                   run out of dog food.");
                e = EventTextbox.c(Faces.Shibe, @"Yeah, me too!");
                e = EventTextbox.c(Faces.Puddle, @"It's like magic, isn't it?");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        //Crest
        NewEP("6cf35a57-afd0-4efa-9931-d6dc3c406a4e");
        {
            var crestTalk0 = new EventPage();
            var crestTalk1 = new EventPage();
            var crestTalk345 = new EventPage();
            var crestTalk7 = new EventPage();
            var crestTalk8 = new EventPage();
            var crestTalk9 = new EventPage();

            e = EventPageSwitch.c(Global.s.CrestTalk).AddEventPage(0, crestTalk0).AddEventPage(1, crestTalk1).AddEventPage(3, crestTalk345).AddEventPage(4, crestTalk345).AddEventPage(5, crestTalk345).AddEventPage(7, crestTalk7).AddEventPage(8, crestTalk8).AddEventPage(9, crestTalk9);

            ep = crestTalk0;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Shibe, @"Do you know where we can find
                                                  wi-fi?").SwitchSides;
                e = EventTextbox.c(Faces.Crest, @"Puddle might know.");
                e = EventTextbox.c(Faces.Crest, @"She's upstairs.");
                e = EventTextbox.c(Faces.Shibe, @"Okay, we'll go ask--").SwitchSides;
                e = EventSFX.c(SFX.Pom_bark);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Crest, @"PUDDLE!");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Crest, @"DO YOU KNOW WHERE TO GET
                                                  WI-FI?");
                e = EventTextboxClose.c;
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.None, @"\C[1]" + PuddleName + @"\C[0]
                                                 WHAT? I CAN'T HEAR YOU!");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Crest, @"DO YOU KNOW WHERE TO GET
                                                  WI-FI?");
                e = EventTextboxClose.c;
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.None, @"\C[1]" + PuddleName + @"\C[0]
                                                 WHAT?");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"How long is this going to go on?!
                                                          We'll just go up and ask--").SwitchSides;
                e = EventSFX.c(SFX.Pom_bark);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Crest, @"WHERE! DO! YOU! FIND! WI-FI!");
                e = EventTextboxClose.c;
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.None, @"\C[1]" + PuddleName + @"\C[0]
                                                 WI-FI?");
                e = EventSFX.c(SFX.Pom_bark);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.Crest, @"YEAH!");
                e = EventTextboxClose.c;
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventShake.c(5, 5, .2f).Wait;
                e = EventTextbox.c(Faces.None, @"\C[1]" + PuddleName + @"\C[0]
                                                 I DUNNO!");
                e = EventTextbox.c(Faces.Crest, @"She doesn't know.");
                e = EventTextbox.c(Faces.Shibe_uh, @"We heard that loud and clear...").SwitchSides;
                e = EventTextbox.c(Faces.Crest, @"See?
                                                  Saved you the trouble of going up
                                                  and asking her yourself.");
                e = EventTextbox.c(Faces.Shibe_uh, @"Thanks, I guess...").SwitchSides;
                e = EventTextbox.c(Faces.Pom, @"tho of course we're still going up 2
                                                talk 2 her anyway");
                e = EventSetGlobal.c(Global.s.CrestTalk, 1);
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = crestTalk1;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Crest, @"Puddle is a pretty lazy dog.");
                e = EventTextbox.c(Faces.Crest, @"We communicate a lot like this.");
                e = EventTextbox.c(Faces.Shibe_uh, @"Doesn't that mean you're pretty lazy,
                                                     too?").SwitchSides;
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = crestTalk345;
            {
                e = EventPlayerMoveable.c(false);
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Crest, @"Help!");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = crestTalk7;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Crest, @"Whenever Puddle squashes a spider,
                                                  she always says the same thing:");
                e = EventTextbox.c(Faces.Crest, @"''I won't forgive you for making Crest
                                                  cry. I'll kill you!''");
                e = EventTextbox.c(Faces.Crest, @"And then she squashes it.");
                e = EventTextbox.c(Faces.Crest, @"Isn't she so cool?");
                e = EventTextbox.c(Faces.Shibe_annoyed, @"You seriously cry every single time
                                                          you see a spider?!").SwitchSides;
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = crestTalk8;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Crest, @"I'm baking dog treats right now.");
                e = EventTextbox.c(Faces.Shibe_uh, @"I'm pretty sure you don't need to wait
                                                     there in front of the oven drooling the
                                                     entire time...").SwitchSides;
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }

            ep = crestTalk9;
            {
                e = EventPlayerMoveable.c(false);
                e = EventTextbox.c(Faces.Crest, @"My owner would never give me treats
                                                  when I was alive.");
                e = EventTextbox.c(Faces.Crest, @"I was always so jealous when I saw
                                                  other dogs getting treats.");
                e = EventTextbox.c(Faces.Pom, @"and here's me
                                                playing the worlds tiniest violin");
                e = EventTextboxClose.c;
                e = EventPlayerMoveable.c(true);
            }
        }

        #endregion


        #region Battles

        var pomAttack = new EventPage();
        ep = pomAttack;
        {
            var taunt = new EventPage();
            var yoMamaJoke = new EventPage();

            e = EventTextboxChoice.c.AddChoice("Taunt", taunt)
                                    .AddChoice("Tell a \"yo mama\" joke", yoMamaJoke);

            ep = taunt;
            {
                //one of the following options is chosen at random

                var taunt0 = new EventPage(); var taunt1 = new EventPage();
                var taunt2 = new EventPage(); var taunt3 = new EventPage();
                var taunt4 = new EventPage(); var taunt5 = new EventPage();
                var taunt6 = new EventPage(); var taunt7 = new EventPage();

                e = EventPageSwitch.c(BattleController.Taunt).AddEventPage(0, taunt0).AddEventPage(1, taunt1).AddEventPage(2, taunt2).AddEventPage(3, taunt3).AddEventPage(4, taunt4).AddEventPage(5, taunt5).AddEventPage(6, taunt6).AddEventPage(7, taunt7);

                ep = taunt0;
                {
                    e = EventTextbox.c(Faces.Pom, @"no one likes u").DontSlide;
                }

                ep = taunt1;
                {
                    e = EventTextbox.c(Faces.Pom, @"senpai will never notice u").DontSlide;
                }

                ep = taunt2;
                {
                    e = EventTextbox.c(Faces.Pom, @"a rock has more of a life
                                                    than u do").DontSlide;
                }

                ep = taunt3;
                {
                    e = EventTextbox.c(Faces.Pom, @"ur so ugly that hello kitty said
                                                    goodbye 2 u").DontSlide;
                }

                ep = taunt4;
                {
                    e = EventTextbox.c(Faces.Pom, @"everyone who ever loved u was
                                                    wrong").DontSlide;
                }

                //fun fact; none of the rest of the taunts happen in Puddle's fight

                ep = taunt5;
                {
                    e = EventTextbox.c(Faces.Pom, @"ur wiener is so small that the vet
                                                    couldnt tell whether u were neutered
                                                    or not").DontSlide;
                }

                ep = taunt6;
                {
                    e = EventTextbox.c(Faces.Pom, @"no one will ever want 2 go out
                                                    with u").DontSlide;
                }

                ep = taunt7;
                {
                    e = EventTextbox.c(Faces.Pom, @"is ur ass jealous of the amount of
                                                    shit that just came out of ur mouth").DontSlide;
                }

                ep = taunt;
                //TODO: show battle anim, punch a all
                e = BattleController.EventDamage.c(Target.Enemy, .2f);
                e = EventTextboxClose.c;
                e = EventSetGlobal.c(BattleController.chargingUp, 1);
            }

            ep = yoMamaJoke;
            {
                //one of the following options is chosen at random

                var yoMama00 = new EventPage();
                var yoMama01 = new EventPage(); var yoMama02 = new EventPage();
                var yoMama03 = new EventPage(); var yoMama04 = new EventPage();
                var yoMama05 = new EventPage(); var yoMama06 = new EventPage();
                var yoMama07 = new EventPage(); var yoMama08 = new EventPage();
                var yoMama09 = new EventPage(); var yoMama10 = new EventPage();
                var yoMama11 = new EventPage(); var yoMama12 = new EventPage();

                e = EventPageSwitch.c(BattleController.YoMamaJoke).AddEventPage(0, yoMama00).AddEventPage(1, yoMama01).AddEventPage(2, yoMama02).AddEventPage(3, yoMama03).AddEventPage(4, yoMama04).AddEventPage(5, yoMama05).AddEventPage(6, yoMama06).AddEventPage(7, yoMama07).AddEventPage(8, yoMama08).AddEventPage(9, yoMama09).AddEventPage(10, yoMama10).AddEventPage(11, yoMama11).AddEventPage(12, yoMama12);

                ep = yoMama00;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so fat").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"when she went to the beach").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"all da whales came up and sang
                                                    ''we r family''").DontSlide;
                }

                ep = yoMama01;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so fat").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"even dora couldnt explore her").DontSlide;
                }

                ep = yoMama02;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so ugly").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"her pillow cries at night").DontSlide;
                }

                ep = yoMama03;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so ugly").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"when she went 2 da haunted house
                                                    she came out with a job application").DontSlide;
                }

                ep = yoMama04;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so ugly").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"if she were a scarecrow
                                                    the corn would run away").DontSlide;
                }

                ep = yoMama05;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama's teeth so yellow").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"i can't believe it's not butter!").DontSlide;
                }

                ep = yoMama06;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so fat").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"when she jumped in the air
                                                    she got stuck").DontSlide;
                }

                ep = yoMama07;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so fat").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"when she wears yellow clothes
                                                    people yell ''taxi''").DontSlide;
                }

                ep = yoMama08;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so fat").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"when she sat on an iphone
                                                    it turned into an ipad").DontSlide;
                }

                ep = yoMama09;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so fat").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"the shadow of her butt weighs
                                                    100 pounds").DontSlide;
                }

                ep = yoMama10;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so stupid").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"she threw a rock at the ground
                                                    and missed").DontSlide;
                }

                ep = yoMama11;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so stupid").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"she climbed over a glass wall
                                                    to see what was on the other
                                                    side").DontSlide;
                }

                ep = yoMama12;
                {
                    e = EventTextbox.c(Faces.Pom, @"yo mama so stupid").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"she stole free bread").DontSlide;
                }

                ep = yoMamaJoke;
                //TODO: show battle anim, punch a all
                e = BattleController.EventDamage.c(Target.Enemy, 10);
                e = EventTextboxClose.c;
                e = EventSetGlobal.c(BattleController.chargingUp, 1);
            }
        }

        //Shibe
        NewEP("2d22a536-343a-4910-a780-bf24656916c7");
        {
            var triggerStartBattle = new EventPage();
            var triggerPomAttack = new EventPage();

            e = EventPageSwitch.c(BattleController.battleTrigger)
                .AddEventPage((int)BattleStates.StartBattle, triggerStartBattle)
                .AddEventPage((int)BattleStates.PomAttack, triggerPomAttack);

            ep = triggerStartBattle;
            {
                e = EventBGM.c(BGM.Field4, .4f);
                e = EventTextbox.c(Faces.Shibe, @"Wh-what's this?").DontSlide;
                e = EventTextbox.c(Faces.Shibe, @"Pom, you're kind of scaring me...").DontSlide;
                e = EventTextboxClose.c;
            }

            ep = triggerPomAttack;
            {
                //NOTE: you can replace this execute event by copying in the entire pomAttack
                //      event contents at the start of this block if you need to have different
                //      text based on who you're actually attacking.
                e = EventPageExecute.c(pomAttack);
                e = EventSetGlobal.c(BattleController.chargingUp, 0);



                var pomTurn1 = new EventPage();
                var pomTurn3 = new EventPage();
                var pomTurn5 = new EventPage();

                e = EventPageSwitch.c(BattleController.pomTurn)
                    .AddEventPage(1, pomTurn1)
                    .AddEventPage(3, pomTurn3)
                    .AddEventPage(5, pomTurn5);

                ep = pomTurn1;
                {
                    e = EventTextbox.c(Faces.Shibe, @"You're hurting me!").DontSlide;
                    e = EventTextboxClose.c;
                }

                ep = pomTurn3;
                {
                    e = EventTextbox.c(Faces.Shibe, @"There's no need to get violent!").DontSlide;
                    e = EventTextboxClose.c;
                }

                ep = pomTurn5;
                {
                    e = EventTextbox.c(Faces.Shibe, @"Fighting is bad!").DontSlide;
                    e = EventTextboxClose.c;
                }

                ep = triggerPomAttack;
                e = EventSetGlobal.c(BattleController.chargingUp, 1);
            }
        }

        //Puddle
        NewEP("2f18fef2-3ba5-4a18-b384-f096754bc8ce");
        {
            var triggerStartBattle = new EventPage();
            var triggerEnemy1Attack = new EventPage();
            var triggerPomAttack = new EventPage();
            var triggerShibeAttack = new EventPage();

            e = EventPageSwitch.c(BattleController.battleTrigger)
                .AddEventPage((int)BattleStates.StartBattle, triggerStartBattle)
                .AddEventPage((int)BattleStates.Enemy1Attack, triggerEnemy1Attack)
                .AddEventPage((int)BattleStates.PomAttack, triggerPomAttack)
                .AddEventPage((int)BattleStates.ShibeAttack, triggerShibeAttack);

            ep = triggerStartBattle;
            {
                e = EventBGM.c(BGM.Field4, .4f);
            }

            ep = triggerEnemy1Attack;
            {
                e = BattleController.EventDamage.c(Target.Ally, 10);
                //TODO: 50/50 charge up or attack
            }

            ep = triggerPomAttack;
            {
                //NOTE: you can replace this execute event by copying in the entire pomAttack
                //      event contents at the start of this block if you need to have different
                //      text based on who you're actually attacking.
                e = EventPageExecute.c(pomAttack);
            }

            ep = triggerShibeAttack;
            {
                var apologize = new EventPage();
                var puppyEyes = new EventPage();
                var playDead = new EventPage();

                e = EventTextboxChoice.c.AddChoice("Apologize", apologize)
                                        .AddChoice("Puppy Eyes", puppyEyes)
                                        .AddChoice("Play Dead", playDead);

                ep = apologize;
                {
                    e = EventTextbox.c(Faces.None, @"Shibe apologized profusely!").DontSlide;
                    //TODO:ShowBattleAnim - Healing A, Enemy (wait)
                    e = EventTextbox.c(Faces.None, @"Puddle looks more fired up than ever!").DontSlide;
                }

                ep = puppyEyes;
                {
                    e = EventTextbox.c(Faces.None, @"Shibe used Puppy Dog Eyes!").DontSlide;
                    e = EventTextbox.c(Faces.None, @"It had no effect on Puddle...").DontSlide;
                }

                ep = playDead;
                {
                    e = EventTextbox.c(Faces.None, @"Shibe played dead!").DontSlide;
                    e = EventTextbox.c(Faces.None, @"It had no effect on Puddle...").DontSlide;
                }

                ep = triggerShibeAttack;
                e = EventTextboxClose.c;
                e = EventSetGlobal.c(BattleController.chargingUp, 1);
            }
        }

        //Bernard
        NewEP("b1ecd61a-be10-4c29-b597-af72660aec37");
        {
            var triggerStartBattle = new EventPage();
            var triggerEnemy1Attack = new EventPage();
            var triggerPomAttack = new EventPage();
            var triggerShibeAttack = new EventPage();
            var triggerEnemyAboutToDie = new EventPage();

            e = EventPageSwitch.c(BattleController.battleTrigger)
                .AddEventPage((int)BattleStates.StartBattle, triggerStartBattle)
                .AddEventPage((int)BattleStates.Enemy1Attack, triggerEnemy1Attack)
                .AddEventPage((int)BattleStates.PomAttack, triggerPomAttack)
                .AddEventPage((int)BattleStates.ShibeAttack, triggerShibeAttack)
                .AddEventPage((int)BattleStates.EnemyAboutToDie, triggerEnemyAboutToDie);

            ep = triggerStartBattle;
            {
                e = EventBGM.c(BGM.Field4, .4f);
            }

            ep = triggerEnemy1Attack;
            {
                //TODO: normal attack
                e = BattleController.EventDamage.c(Target.Ally, 10);
            }

            ep = triggerPomAttack;
            {
                //NOTE: you can replace this execute event by copying in the entire pomAttack
                //      event contents at the start of this block if you need to have different
                //      text based on who you're actually attacking.
                e = EventPageExecute.c(pomAttack);
            }

            ep = triggerShibeAttack;
            {
                var sit = new EventPage();
                var stay = new EventPage();
                var rollOver = new EventPage();
                var dig = new EventPage();

                e = EventTextboxChoice.c.AddChoice("Sit", sit)
                                        .AddChoice("Stay", stay)
                                        .AddChoice("Roll Over", rollOver)
                                        .AddChoice("Dig", dig);

                ep = sit;
                {
                    e = EventTextbox.c(Faces.None, @"It had no effect on Bernard...").DontSlide;
                }

                ep = stay;
                {
                    e = EventTextbox.c(Faces.None, @"Shibe stayed!").DontSlide;
                    e = EventTextbox.c(Faces.None, @"It had no effect on Bernard...").DontSlide;
                }

                ep = rollOver;
                {
                    e = EventTextbox.c(Faces.None, @"Shibe rolled over!").DontSlide;
                    //TODO:ShowBattleAnim - Intellect Diminish, Shibe Ally (wait)
                    e = EventTextbox.c(Faces.None, @"Shibe became more vulnerable to the
                                                     enemy").DontSlide;
                }

                ep = dig;
                {
                    e = EventTextbox.c(Faces.None, @"Shibe dug an important hole!").DontSlide;
                    e = EventTextbox.c(Faces.None, @"Not just any hole!").DontSlide;
                }

                ep = triggerShibeAttack;
                e = EventTextboxClose.c;
                e = EventSetGlobal.c(BattleController.chargingUp, 1);
            }

            ep = triggerEnemyAboutToDie;
            {
                e = EventSetGlobal.c(BattleController.chargingUp, 0);
                e = EventTextbox.c(Faces.Bernard, @"Guh! You're a monster!").DontSlide;
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"take back what u said").DontSlide;
                e = EventTextbox.c(Faces.Pom, @"shibe doesnt have a thing 4 crest").DontSlide;
                e = EventTextbox.c(Faces.Bernard, @"Okay, okay! He doesn't").DontSlide;
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"now say ''i ship hus/shibe''").DontSlide;
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventTextbox.c(Faces.Shibe, @"Wha?!").DontSlide;
                e = EventTextbox.c(Faces.Pom, @"say it").DontSlide;
                e = EventTextbox.c(Faces.Bernard, @"I...ship Hus/Shibe!").DontSlide;
                e = EventTextbox.c(Faces.Bernard, @"Are you happy now?").DontSlide;
                e = EventTextbox.c(Faces.None, @"Bernard ran away while sobbing!").DontSlide;
                e = EventSetGlobal.c(Global.s.BernardTalk, 5);
                e = EventTextboxClose.c;
                e = EventSetGlobal.c(BattleController.chargingUp, 1);
            }
        }

        //Hus&Shibe
        NewEP("20244fa8-22c7-409f-ae4a-f13e8a315c9a");
        {
            var triggerStartBattle = new EventPage();
            var triggerEnemy1Attack = new EventPage();
            var triggerEnemy2Attack = new EventPage();
            var triggerPomAttack = new EventPage();

            e = EventPageSwitch.c(BattleController.battleTrigger)
                .AddEventPage((int)BattleStates.StartBattle, triggerStartBattle)
                .AddEventPage((int)BattleStates.Enemy1Attack, triggerEnemy1Attack)
                .AddEventPage((int)BattleStates.Enemy2Attack, triggerEnemy2Attack)
                .AddEventPage((int)BattleStates.PomAttack, triggerPomAttack);

            ep = triggerStartBattle;
            {
                e = EventBGM.c(BGM.Field4, .4f);
                e = EventSetGlobal.c(Global.s.StopPom, 2);
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventTextbox.c(Faces.Shibe, @"Wait, you two!").DontSlide;
                e = EventTextbox.c(Faces.Shibe, @"Don't fight!").DontSlide;
                e = EventSFX.c(SFX.Pom_bark);
                e = EventTextbox.c(Faces.Pom, @"no fukkin way").DontSlide;
                e = EventTextbox.c(Faces.Pom, @"u 2 r going down").DontSlide;
                e = EventSFX.c(SFX.Medium_Dog1);
                e = EventTextbox.c(Faces.Hus, @"Sorry, Shibe.").DontSlide;
                e = EventTextbox.c(Faces.Hus, @"Looks like I have no choice.").DontSlide;
                e = EventTextboxClose.c;
            }

            ep = triggerEnemy1Attack;
            {
                //TODO: normal attack
                e = BattleController.EventDamage.c(Target.Ally, 10);
            }

            ep = triggerPomAttack;
            {
                //NOTE: you can replace this execute event by copying in the entire pomAttack
                //      event contents at the start of this block if you need to have different
                //      text based on who you're actually attacking.
                e = EventPageExecute.c(pomAttack);
            }

            ep = triggerEnemy2Attack;
            {
                var turn1 = new EventPage();
                var turn3 = new EventPage();
                var turn4 = new EventPage();

                e = EventPageSwitch.c(BattleController.enemy2Turn).AddEventPage(1, turn1).AddEventPage(3, turn3).AddEventPage(4, turn4);

                ep = turn1;
                {
                    e = EventTextbox.c(Faces.None, @"Shibe dug an important hole!").DontSlide;
                    e = EventTextbox.c(Faces.None, @"Not just any hole!").DontSlide;
                }

                ep = turn3;
                {
                    e = EventTextbox.c(Faces.None, @"Shibe used Puppy Dog Eyes!").DontSlide;
                    e = EventTextbox.c(Faces.None, @"It had no effect on Pom...").DontSlide;
                    e = EventTextbox.c(Faces.Hus, @"...").DontSlide;
                    e = EventSFX.c(SFX.Medium_Dog1);
                    e = EventTextbox.c(Faces.Hus, @"Shibe, stop that!").DontSlide;
                    e = EventSFX.c(SFX.Medium_Dog1);
                    e = EventTextbox.c(Faces.Shibe, @"H-huh?").DontSlide;
                    e = EventSFX.c(SFX.Medium_Dog1);
                    e = EventTextbox.c(Faces.Hus, @"It's distracting!").DontSlide;
                    e = EventSFX.c(SFX.Medium_Dog1);
                    e = EventTextbox.c(Faces.Shibe, @"O-okay!").DontSlide;
                }

                ep = turn4;
                {
                    e = EventTextbox.c(Faces.None, @"Shibe rolled over!").DontSlide;
                    //TODO:ShowBattleAnim - Intellect Diminish, Shibe Ally (wait)
                    e = EventTextbox.c(Faces.None, @"Shibe became more vulnerable to the
                                                     enemy!").DontSlide;
                }

                ep = triggerEnemy2Attack;
                e = EventTextboxClose.c;
            }
        }

        //York
        NewEP("afc7f890-5609-42c9-815e-e6d083816532");
        {
            var triggerStartBattle = new EventPage();
            var triggerPomAttack = new EventPage();

            e = EventPageSwitch.c(BattleController.battleTrigger)
                .AddEventPage((int)BattleStates.StartBattle, triggerStartBattle)
                .AddEventPage((int)BattleStates.PomAttack, triggerPomAttack);

            ep = triggerStartBattle;
            {
                e = EventBGM.c(BGM.Field4, .4f);
            }

            ep = triggerPomAttack;
            {
                e = EventTextbox.c(Faces.Pom, @"suck").DontSlide;
                e = EventTextbox.c(Faces.Pom, @"on").DontSlide;
                e = EventTextbox.c(Faces.Pom, @"my").DontSlide;
                e = EventTextbox.c(Faces.Pom, @"misSILE PUNCH!!!").DontSlide;
                //TODO:ShowBattleAnim - Non-elemental S 1, Enemy (wait)
                e = BattleController.EventDamage.c(Target.Enemy, 100);
                e = EventTextbox.c(Faces.York, @"Gnnrk...!").DontSlide;
                e = EventSetGlobal.c(BattleController.chargingUp, 1);
                e = BattleController.EventEndBattle.c;
            }
        }

        //Dog
        NewEP("f3f9bf44-4dab-42ac-99f2-abeeb497dceb");
        {
            var triggerStartBattle = new EventPage();
            var triggerEnemy1Attack = new EventPage();
            var triggerPomAttack = new EventPage();

            e = EventPageSwitch.c(BattleController.battleTrigger)
                .AddEventPage((int)BattleStates.StartBattle, triggerStartBattle)
                .AddEventPage((int)BattleStates.Enemy1Attack, triggerEnemy1Attack)
                .AddEventPage((int)BattleStates.PomAttack, triggerPomAttack);

            ep = triggerStartBattle;
            {
                e = EventBGM.c(BGM.Mystery3, .4f);
            }

            ep = triggerEnemy1Attack;
            {
                e = EventTextbox.c(Faces.None, @"You cannot grasp the true form of Dog's attack!").DontSlide;
                e = EventFlashScreen.c(.5f, new Color(.121f, .121f, .121f, .121f));
                e = EventWait.c(.5f);
                //TODO:ShowBattleAnim - Punch C, Pom
                e = BattleController.EventDamage.c(Target.Ally, 100);
                e = EventTextboxClose.c;
            }

            ep = triggerPomAttack;
            {
                var attack0 = new EventPage();
                var attack1 = new EventPage();
                var attack2 = new EventPage();
                var attack3 = new EventPage();
                var attack4 = new EventPage();

                e = EventPageSwitch.c(BattleController.pomTurn).AddEventPage(0, attack0).AddEventPage(1, attack1).AddEventPage(2, attack2).AddEventPage(3, attack3).AddEventPage(4, attack4);

                ep = attack0;
                {
                    e = EventTextbox.c(Faces.Pom, @"im in da zone").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"autozone").DontSlide;
                }

                ep = attack1;
                {
                    e = EventTextbox.c(Faces.Pom, @"kawoshin? no. more like kawobunga").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"surf's up shinji kun").DontSlide;
                }

                ep = attack2;
                {
                    e = EventTextbox.c(Faces.Pom, @"[weird edgeworth noises]").DontSlide;
                }

                ep = attack3;
                {
                    e = EventTextbox.c(Faces.Pom, @"i fukkin cant believe the 12th doctor
                                                    is mitt romney").DontSlide;
                }

                ep = attack4;
                {
                    e = EventTextbox.c(Faces.Pom, @"sorry but i think we should break up").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"it's not you it's-a-me mario").DontSlide;
                }

                ep = triggerPomAttack;
                e = EventTextboxClose.c;
                //TODO:ShowBattleAnim - Fire Magic S 2, Enemy (Wait)
                e = BattleController.EventDamage.c(Target.Enemy, 999);
                e = EventSetGlobal.c(BattleController.chargingUp, 1);
            }
        }

        //Shibe Final
        NewEP("5d814f08-7eaa-4c77-9ef6-e28e0e523108");
        {
            var triggerStartBattle = new EventPage();
            var triggerEnemy1Attack = new EventPage();
            var triggerPomAttack = new EventPage();

            e = EventPageSwitch.c(BattleController.battleTrigger)
                .AddEventPage((int)BattleStates.StartBattle, triggerStartBattle)
                .AddEventPage((int)BattleStates.Enemy1Attack, triggerEnemy1Attack)
                .AddEventPage((int)BattleStates.PomAttack, triggerPomAttack);

            ep = triggerStartBattle;
            {
                e = EventBGM.c(BGM.EricSkiff_UnderStars, .4f);
            }

            ep = triggerEnemy1Attack;
            {
                var shibeTurn00 = new EventPage();
                var shibeTurn01 = new EventPage(); var shibeTurn02 = new EventPage();
                var shibeTurn03 = new EventPage(); var shibeTurn04 = new EventPage();
                var shibeTurn05 = new EventPage(); var shibeTurn06 = new EventPage();
                var shibeTurn07 = new EventPage(); var shibeTurn08 = new EventPage();
                var shibeTurn09 = new EventPage(); var shibeTurn10 = new EventPage();
                var shibeTurn11 = new EventPage(); var shibeTurn12 = new EventPage();
                var shibeTurn13 = new EventPage(); var shibeTurn14 = new EventPage();
                var shibeTurn15 = new EventPage(); var shibeTurn16 = new EventPage();

                e = EventPageSwitch.c(BattleController.enemy1Turn).AddEventPage(0, shibeTurn00).AddEventPage(1, shibeTurn01).AddEventPage(2, shibeTurn02).AddEventPage(3, shibeTurn03).AddEventPage(4, shibeTurn04).AddEventPage(5, shibeTurn05).AddEventPage(6, shibeTurn06).AddEventPage(7, shibeTurn07).AddEventPage(8, shibeTurn08).AddEventPage(9, shibeTurn09).AddEventPage(10, shibeTurn10).AddEventPage(11, shibeTurn11).AddEventPage(12, shibeTurn12).AddEventPage(13, shibeTurn13).AddEventPage(14, shibeTurn14).AddEventPage(15, shibeTurn15).AddEventPage(16, shibeTurn16);

                ep = shibeTurn00;
                {
                    e = EventSFX.c(SFX.Medium_Dog1);
                    e = EventTextbox.c(Faces.Shibe, @"I know wi-fi is important to you!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"But it doesn't have to be this way!").DontSlide;
                }

                ep = shibeTurn01;
                {
                    e = EventTextbox.c(Faces.Pom, @"u dont understand").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"i need wi-fi like i need air").DontSlide;
                }

                ep = shibeTurn02;
                {
                    e = EventTextbox.c(Faces.Pom, @"i dont need anything else").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"the internet is the essence of my
                                                    entire existance").DontSlide;
                }

                ep = shibeTurn03;
                {
                    e = EventTextbox.c(Faces.Shibe, @"You don't have to be like this!").DontSlide;
                }

                ep = shibeTurn04;
                {
                    e = EventSFX.c(SFX.Medium_Dog1);
                    e = EventTextbox.c(Faces.Shibe, @"You're Dog!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"You have the power to do anything right now!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"Literally anything!").DontSlide;
                }

                ep = shibeTurn05;
                {
                    e = EventTextbox.c(Faces.Shibe, @"There are so many things that only you can do!").DontSlide;
                }

                ep = shibeTurn06;
                {
                    e = EventTextbox.c(Faces.Shibe, @"Just think about it!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"You can make the frisbee machine so
                                                      that it never breaks!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"You can erase every spider in the
                                                      world!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"You can eliminate violence and
                                                      fighting!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"You can make it so that dogs like
                                                      Bernard can't creep on others!").DontSlide;
                }

                ep = shibeTurn07;
                {
                    e = EventTextbox.c(Faces.Shibe, @"You can fix so many things that are
                                                      wrong here...").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"If you'll just get up and actually make
                                                      an effort to change them!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"If you don't do it, no one will!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"No one else can!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"...").DontSlide;
                }

                ep = shibeTurn08;
                {
                    e = EventTextbox.c(Faces.Shibe, @"Please don't just sit here surfing the
                                                      web while the world falls apart around
                                                      you...").DontSlide;
                }

                ep = shibeTurn09;
                {
                    e = EventTextbox.c(Faces.Pom, @"but thats all i know how 2 do").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"all i know how 2 do is sit in front of
                                                      a computer").DontSlide;
                }

                ep = shibeTurn10;
                {
                    e = EventTextbox.c(Faces.Pom, @"it's 2 late").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @"i've never done anything useful in my
                                                      entire life").DontSlide;
                }

                ep = shibeTurn11;
                {
                    e = EventTextbox.c(Faces.Shibe, @"It's never too late to start!").DontSlide;
                    e = EventSFX.c(SFX.Medium_Dog1);
                    e = EventTextbox.c(Faces.Shibe, @"Not for this, not for anything!").DontSlide;
                }

                ep = shibeTurn12;
                {
                    e = EventTextbox.c(Faces.Shibe, @"You can't change your past, but you
                                                      can change your future!").DontSlide;
                }

                ep = shibeTurn13;
                {
                    e = EventTextbox.c(Faces.Shibe, @"And if we keep looking, I'm sure we'll
                                                      find another way to get wi-fi!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"We'll figure something out!").DontSlide;
                }

                ep = shibeTurn14;
                {
                    e = EventTextbox.c(Faces.Shibe, @"So please...").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"Don't give everything up!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"You need to save the world right now!").DontSlide;
                }

                ep = shibeTurn15;
                {
                    e = EventTextbox.c(Faces.Shibe, @"I believe in you, Pom!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"You can do it!").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"You don't need to be afraid of
                                                      anything!").DontSlide;
                }

                ep = shibeTurn16;
                {
                    e = EventTextbox.c(Faces.Shibe, @"I know it's hard, and but...please...").DontSlide;
                    e = EventTextbox.c(Faces.Shibe, @"Do something...").DontSlide;
                    e = EventTextbox.c(Faces.None, @"Shibe is crying really hard.").DontSlide;
                    e = EventTextbox.c(Faces.Pom, @".............").DontSlide;
                    e = EventWait.c(2f);

                    var end = new EventPage();

                    e = EventPageSwitch.c(Global.s.BadEnd).AddEventPage(1, triggerPomAttack).AddEventPage(0, end);

                    ep = end;
                    e = EventSetGlobal.c(BattleController.chargingUp, 1);
                    e = BattleController.EventEndBattle.c;
                }

                ep = triggerEnemy1Attack;
                e = EventTextboxClose.c;
            }

            ep = triggerPomAttack;
            {
                e = EventTextbox.c(Faces.Pom, @"goodbye shibe").DontSlide;
                e = EventSetGlobal.c(Global.s.BadEnd, 1);
                //TODO:ShowBattleAnim - Fire Magic S 2, Enemy (Wait)
                e = BattleController.EventDamage.c(Target.Enemy, 9999);
                e = EventTextboxClose.c;
                e = EventSetGlobal.c(BattleController.chargingUp, 1);
                e = BattleController.EventEndBattle.c;
            }
        }

        #endregion

        //.. You're done! That's it. The rest of the events are all the pure logic event pages. No more translations that need to be done. :)















        #region Logic Only EventPages

        #region Field - Walk-to-Shibe Line

        NewEP("74bb2385-60e2-4347-a5e8-f2bba5a6d98c"); //top
        {
            tempEP = new EventPage(); e = EventPageSwitch.c(Global.s.IntroGround).AddEventPage(0, tempEP); ep = tempEP;
            e = EventPlayerMoveable.c(false);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(DownRight);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(DownRight);
            e = EventWait.c(.33f);
            e = EventSetGlobal.c(Global.s.ShibeIntro, 1);
            e = EventMovePlayer.c(Right);
        }

        NewEP("330be885-184e-4c81-bb03-58032f0797e9"); //above mid
        {
            tempEP = new EventPage(); e = EventPageSwitch.c(Global.s.IntroGround).AddEventPage(0, tempEP); ep = tempEP;
            e = EventPlayerMoveable.c(false);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(DownRight);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventSetGlobal.c(Global.s.ShibeIntro, 1);
            e = EventMovePlayer.c(Right);
        }

        NewEP("a20c7976-0f55-464a-bc63-d598ca23e448"); //mid
        {
            tempEP = new EventPage(); e = EventPageSwitch.c(Global.s.IntroGround).AddEventPage(0, tempEP); ep = tempEP;
            e = EventPlayerMoveable.c(false);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventSetGlobal.c(Global.s.ShibeIntro, 1);
            e = EventMovePlayer.c(Right);
        }

        NewEP("647c580b-b0f2-41f8-b551-2d55ba4ee830"); //below mid
        {
            tempEP = new EventPage(); e = EventPageSwitch.c(Global.s.IntroGround).AddEventPage(0, tempEP); ep = tempEP;
            e = EventPlayerMoveable.c(false);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(UpRight);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventSetGlobal.c(Global.s.ShibeIntro, 1);
            e = EventMovePlayer.c(Right);
        }

        NewEP("a5e1dea9-1a38-4bac-9e46-7b6d28575087"); //bottom
        {
            tempEP = new EventPage(); e = EventPageSwitch.c(Global.s.IntroGround).AddEventPage(0, tempEP); ep = tempEP;
            e = EventPlayerMoveable.c(false);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(Right);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(UpRight);
            e = EventWait.c(.33f);
            e = EventMovePlayer.c(UpRight);
            e = EventWait.c(.33f);
            e = EventSetGlobal.c(Global.s.ShibeIntro, 1);
            e = EventMovePlayer.c(Right);
        }

        #endregion

        //null
        NewEP("96841974-fc70-4598-831e-d954b22adfc5");
        {
            e = EventPlayerMoveable.c(false);
            e = EventTPPlayer.c(new Vector2(-44.5f, -21.5f), SpriteDir.Down).instantTeleport;
            e = EventTextbox.c(Faces.Pom, @"Stop that, hacker.");
            e = EventTextboxClose.c;
            e = EventPlayerMoveable.c(true);
        }

        #endregion
        
        Global.ActiveLanguage.value = curLang;
    }
}







