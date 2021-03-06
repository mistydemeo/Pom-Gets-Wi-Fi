﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPositioner : MonoBehaviour {
    static EventPositioner instance;

    //park
    public GameObject dustBunny;

    public SpriteRenderer stoneBlock;
    public List<Sprite> stoneBlockSprites = new List<Sprite>();
    
    public GameObject lineBlock;
    public GameObject shermanBlock;
    public GameObject closeToSherman;
    public GameObject exitParkTrigger;
    public GameObject parkFinishedTrigger;

    public GameObject noLeaveParkTown;
    public GameObject noLeaveParkObservatory;

    public List<GameObject> crestHouseExits = new List<GameObject>();
    public GameObject crestHouseExitBlocker;

    public NPCController chiController;
    public GameObject spider;

    public GameObject FastFrisbees;
    public GameObject SlowFrisbees;
    public GameObject SuperFrisbee;

    public GameObject FrisbeeTrap;
    public GameObject FrisbeeTrapTrigger;
    public GameObject MachineCheckedTrigger;

    public GameObject Gate_Open;
    public GameObject Gate_Closed;
    public GameObject Gate_ShibeAndHusPile;

    public SpriteRenderer purpleSpace;
    public ContinuousPan purpleSpacePan;

    public Sprite redSpaceSprite;
    public Sprite purpleSpaceSprite;

    public GameObject yellBoundary;

    int oldCrestTalk = -1;
    int oldPuddleTalk = -1;
    int oldParkState = -1;
    int oldFrisbeeTrap = -1;

    int oldExtraParty = -1;

    int oldCrestStalk = -1;

    public static Vector3 nullPos = new Vector3(-20, 0, 0);

    void Start () {
        instance = this;
	}

    public static void CheckPositions()
    {
        instance.check();
    }

    void check()
    {
        var s = Global.ActiveSavefile;
        var up = (Vector3)Vector2.up;
        var right = (Vector3)Vector2.right;
        var down = (Vector3)Vector2.down;
        var left = (Vector3)Vector2.left;
        var hus = NPCList.GetNPC(NPC.Hus);
        var chi = NPCList.GetNPC(NPC.Chi);

        if(Global.s.DogTalk > 0)
        {
            //yooooo just gonna override all the other stuff so I don't have to worry about figuring out what needs to be moved where
            //not going to be teleporting NPCs around based on variables

            if (s.RedSpace == 2)
            {
                purpleSpacePan.speed = 3f;
            }
            else if (s.RedSpace == 3)
            {
                purpleSpacePan.speed = 6f;
            }
            else if (s.RedSpace == 4)
            {
                purpleSpace.sprite = purpleSpaceSprite;
                purpleSpacePan.speed = 0f;
            }

            return;
        }

        if (s.SharpeiTalk.value == 3)
        {
            if(s.ShibeInParty > 0)
                NPCList.GetNPC(NPC.Sharpeii).transform.position = new Vector3(18.5f, -55f);
            else
                NPCList.GetNPC(NPC.Sharpeii).transform.position = nullPos;
        }
        else NPCList.GetNPC(NPC.Sharpeii).transform.position = new Vector3(21.5f, -56f);

        if (s.DustBunny == 0) dustBunny.transform.position = new Vector3(63.5f, 56.5f);
        else dustBunny.transform.position = nullPos;
        
        switch (Global.s.StoneBlockSearch)
        {
            case 0: case 1: case 2: case 3: stoneBlock.sprite = null; break;
            case 4: case 5: stoneBlock.sprite = stoneBlockSprites[1]; break;
            case 6: stoneBlock.sprite = stoneBlockSprites[2]; break;
            case 7: stoneBlock.sprite = stoneBlockSprites[3]; break;
            case 8: stoneBlock.sprite = stoneBlockSprites[4]; break;
            case 9: stoneBlock.sprite = stoneBlockSprites[5]; break;
        }

        if (s.ParkState == 0) shermanBlock.transform.position = new Vector3(64f, -17.5f);
        else shermanBlock.transform.position = nullPos;

        if (s.ParkState == 0) closeToSherman.transform.position = new Vector3(64f, -16.5f);
        else closeToSherman.transform.position = nullPos;

        if (s.ParkState == 1) exitParkTrigger.transform.position = new Vector3(64f, -17.5f);
        else exitParkTrigger.transform.position = nullPos;

        if (s.ParkState == 1) noLeaveParkTown.transform.position = new Vector3(34.5f, -20f);
        else noLeaveParkTown.transform.position = nullPos;

        if (s.ParkState == 1) noLeaveParkObservatory.transform.position = new Vector3(51f, -25.5f);
        else noLeaveParkObservatory.transform.position = nullPos;

        if (s.ParkState == 2) parkFinishedTrigger.transform.position = new Vector3(64.5f, -17.5f);
        else parkFinishedTrigger.transform.position = nullPos;

        if (s.ParkState == 2) lineBlock.transform.position = nullPos;
        else lineBlock.transform.position = new Vector3(66.5f, -21.5f);

        if (s.ParkState > 0) chiController.ConstantlyWalk = false;
        else chiController.ConstantlyWalk = true;

        if (s.StoneBlockSearch == 3) s.ShibeTalk.value = 6;

        if(s.CrestTalk == 4) { crestHouseExitBlocker.SetActive(true); foreach (var exit in crestHouseExits) { exit.SetActive(false); } }
        else { crestHouseExitBlocker.SetActive(false); foreach (var exit in crestHouseExits) { exit.SetActive(true); } }

        if (s.CrestTalk >= 2 && s.CrestTalk <= 4) spider.SetActive(true);
        if (s.CrestTalk == 5) spider.transform.position = nullPos;
        else if (s.PuddleTalk == 3) spider.SetActive(false);

        var crest = NPCList.GetNPC(NPC.Crest);
        var puddle = NPCList.GetNPC(NPC.Puddle);
        if (s.CrestTalk == 2)
        {
            crest.transform.position = new Vector3(2.5f, -50f);
            puddle.transform.position = nullPos;
        }

        if(oldCrestTalk != s.CrestTalk)
        {
            var defaultPos = new Vector3(-0.5f, -50f);

            switch (s.CrestTalk)
            {
                case 2: crest.transform.position = defaultPos + (right * 3); break;
                case 7: crest.transform.position = defaultPos + (left * 6); break;
                case 8: crest.transform.position = defaultPos + (left * 6) + (up * 2); break;
                case 9: crest.transform.position = defaultPos + (left * 10) + (up * 9); break;
            }

            oldCrestTalk = s.CrestTalk;
        }

        if (oldPuddleTalk != s.PuddleTalk)
        {
            var defaultPos = new Vector3(-10.5f, -41f);

            switch (s.PuddleTalk)
            {
                case 0: case 4: puddle.transform.position = defaultPos; break;
                case 2: puddle.transform.position = defaultPos + (down * 12) + (left * 1); puddle.SetFacingDirection(SpriteDir.Up); break;
                case 3: puddle.transform.position = defaultPos + (down * 11) + (left * 1); break;
                case 5: puddle.transform.position = new Vector3(-0.5f, -50f); break;
            }

            oldPuddleTalk = s.PuddleTalk;
        }

        if(oldParkState != s.ParkState)
        {
            FastFrisbees.SetActive(s.ParkState == 0 || s.ParkState == 1);
            SlowFrisbees.SetActive(s.ParkState == 2);

            if (oldParkState != 2 && s.ParkState == 2)
            {
                NPCList.GetNPC(NPC.Goldie).transform.position = nullPos;
                NPCList.GetNPC(NPC.Labra).transform.position = nullPos;
                NPCList.GetNPC(NPC.Sherman).transform.position = nullPos;
                NPCList.GetNPC(NPC.Chi).transform.position = nullPos;
                NPCList.GetNPC(NPC.Alma).transform.position = new Vector2(44.5f, -4f);
            }

            oldParkState = s.ParkState;
        }

        if(oldFrisbeeTrap != s.FrisbeeTrap)
        {
            SuperFrisbee.SetActive(s.FrisbeeTrap == 1);
            FrisbeeTrap.SetActive(s.FrisbeeTrap == 1);
            FrisbeeTrapTrigger.SetActive(s.FrisbeeTrap <= 1);

            oldFrisbeeTrap = s.FrisbeeTrap;
        }

        MachineCheckedTrigger.SetActive(Global.s.MachineChecked < 1 && Global.s.ParkState == 1);

        if(oldExtraParty != 2 && s.ExtraParkPartyMember == 2)
        {
            oldExtraParty = 2;
            
            var oldHusPos = hus.transform.position;
            var oldHusLook = hus.facingDir;

            hus.transform.position = chi.transform.position;
            hus.SetFacingDirection(SpriteDir.Up);

            chi.transform.position = oldHusPos;
            chi.SetFacingDirection(oldHusLook);
        }

        yellBoundary.SetActive(Global.s.UgTalk <= 1);

        var malty = NPCList.GetNPC(NPC.Malty);
        switch (s.MaltyTalk)
        {
            case 1: case 2:
                if (s.ShibeInParty > 0) { malty.transform.position = new Vector3(96.5f, -51f); malty.SetFacingDirection(s.MaltyTalk == 1 ? SpriteDir.Left : SpriteDir.Right); }
                else NPCList.GetNPC(NPC.Malty).transform.position = nullPos;
                break;
            case 6:
                malty.transform.position = new Vector3(96.5f, -51f); malty.SetFacingDirection(SpriteDir.Right);
                chi.transform.position = new Vector3(52.5f, -20f); chi.SetFacingDirection(SpriteDir.Left);
                break;
            default:
                NPCList.GetNPC(NPC.Malty).transform.position = nullPos;
                break;
        }

        var bernard = NPCList.GetNPC(NPC.Bernard);
        switch(s.BernardTalk)
        {
            case 1: case 2: case 3: case 4:
                bernard.transform.position = new Vector3(85.5f, -24f);
                break;
            default:
                bernard.transform.position = nullPos;
                break;
        }
        
        if (oldCrestStalk != s.CrestStalkFest)
        {
            switch (s.CrestStalkFest)
            {
                case 1:
                    crest.transform.position = new Vector3(9.5f, -19f);
                    crest.SetFacingDirection(SpriteDir.Down);
                    break;
                case 2:
                    crest.transform.position = new Vector3(-2.5f, -17f);
                    crest.SetFacingDirection(SpriteDir.Right);
                    break;
                case 4:
                    crest.transform.position = new Vector3(21.5f, -23f);
                    crest.SetFacingDirection(SpriteDir.Right);
                    break;
                case 6:
                    crest.transform.position = new Vector3(47.5f, -20f);
                    crest.SetFacingDirection(SpriteDir.Right);
                    
                    hus.transform.position = new Vector3(47.5f, -21f);
                    hus.SetFacingDirection(SpriteDir.Up);
                    
                    chi.transform.position = new Vector3(48.5f, -20f);
                    chi.SetFacingDirection(SpriteDir.Left);
                    break;
                case 7:
                    hus.transform.position = nullPos;
                    hus.SetFacingDirection(SpriteDir.Up);
                    
                    chi.transform.position = nullPos;
                    chi.SetFacingDirection(SpriteDir.Left);
                    break;
            }

            oldCrestStalk = s.CrestStalkFest;
        }

        if(s.UgTalk == 2 && s.MaltyTalk < 3 && s.PictureTaken > 0)
        {
            puddle.transform.position = new Vector3(98.5f, -20f);
            puddle.SetFacingDirection(SpriteDir.Left);

            crest.transform.position = new Vector3(99.5f, -20f);
            crest.SetFacingDirection(SpriteDir.Left);
        }

        var pom = NPCList.GetNPC(NPC.Pom);
        if (s.HusTalk == 5)
        {
            hus.transform.position = new Vector3(92.5f, -20f);
            hus.SetFacingDirection(SpriteDir.Right);
        }

        if(s.HusTalk == 6 || s.HusTalk == 9)
        {
            hus.transform.position = nullPos;
            NPCList.GetNPC(NPC.Shibe).transform.position = nullPos;
        }

        if(s.StopPom > 0)
        {
            NPCList.GetNPC(NPC.DavePointer).transform.position = new Vector3(122.5f, 27f);
        }

        var corg = NPCList.GetNPC(NPC.Corg);
        if (s.GateOpened == 0)
        {
            if (s.CorgTalk == 1)
            {
                corg.transform.position = new Vector3(123.5f, -20f);
            }
            else if ((s.CorgTalk == 3 || (s.ShibeInParty == 0 && s.CorgKeys == 1)))
            {
                corg.transform.position = new Vector3(135.5f, -20f);
            }
            else
            {
                corg.transform.position = nullPos;
            }
        }
        else
        {
            corg.transform.position = nullPos;
        }

        var gateClosed = s.GateOpened == 0;
        Gate_Closed.SetActive(gateClosed);
        Gate_Open.SetActive(!gateClosed);

        Gate_ShibeAndHusPile.SetActive(s.StopPom >= 2);

        if(s.HusTalk == 5 && pom.transform.position.x > 103)
        {
            hus.transform.position = new Vector3(119.5f, -20f);
            hus.SetFacingDirection(SpriteDir.Right);
        }

        if(s.HusTalk == 7 || s.HusTalk == 8)
        {
            hus.transform.position = nullPos;
            NPCList.GetNPC(NPC.Shibe).transform.position = nullPos;
        }

        if(s.RedSpace == 1)
        {
            purpleSpace.sprite = redSpaceSprite;
            purpleSpacePan.speed = .3f;
        }
    }
}
