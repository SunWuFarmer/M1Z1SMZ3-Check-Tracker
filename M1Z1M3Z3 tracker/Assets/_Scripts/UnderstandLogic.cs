using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class UnderstandLogic : MonoBehaviour
{
  [SerializeField] private NormalLogic _normalLogic;
  [SerializeField] private ArrayOfItems itemsFlags;
  [SerializeField] private NormalCheck missle230;
  [SerializeField] private NormalCheck bt;
  [SerializeField] private NormalCheck backGauntlet;
  [SerializeField] private NormalCheck toptopWs;
  [SerializeField] private NormalCheck backWs;
  [SerializeField] private NormalCheck robots;
  [SerializeField] private NormalCheck wSspeed;
  [SerializeField] private NormalCheck rightsidesuper;
  [SerializeField] private NormalCheck leftsidesuper;
  [SerializeField] private NormalCheck wSmissles;
  [SerializeField] private NormalCheck grav;
  [SerializeField] private NormalCheck wStopCave;
  [SerializeField] private NormalCheck shipPBs;
  [SerializeField] private NormalCheck cAve;
  [SerializeField] private NormalCheck cwj;
  [SerializeField] private NormalCheck terminator;
  [SerializeField] private NormalCheck oldMb;
  [SerializeField] private NormalCheck climbSupers;
  [SerializeField] private NormalCheck draymissle;
  [SerializeField] private NormalCheck space;
  [SerializeField] private NormalCheck botwoonE;
  [SerializeField] private NormalCheck plamsa;
  [SerializeField] private NormalCheck waterhole;
  [SerializeField] private NormalCheck beach;
  [SerializeField] private NormalCheck gauntlet;
  [SerializeField] private NormalCheck mamatSide;
  [SerializeField] private NormalCheck mamaT;
  [SerializeField] private NormalCheck aquaDuct1;
  [SerializeField] private NormalCheck aquaDuct2;
  [SerializeField] private NormalCheck sandpitleft;
  [SerializeField] private NormalCheck sandpitRight1;
  [SerializeField] private NormalCheck sandpitRight2;
  [SerializeField] private NormalCheck bigpink;
  [SerializeField] private NormalCheck bigpink2;
  [SerializeField] private NormalCheck brigde;
  [SerializeField] private NormalCheck earlySuper;
  [SerializeField] private NormalCheck brinResevre;
  [SerializeField] private NormalCheck backofEarlySupers;
  [SerializeField] private NormalCheck mission;
  [SerializeField] private NormalCheck etttcoonsPb;
  [SerializeField] private NormalCheck etttcoonssuper;
  [SerializeField] private NormalCheck etttcoonsE;
  [SerializeField] private NormalCheck charge;
  [SerializeField] private NormalCheck waterway;
  [SerializeField] private NormalCheck waveGate;
  [SerializeField] private NormalCheck spospo;
  [SerializeField] private NormalCheck leftofMorph;
  [SerializeField] private NormalCheck morph;
  [SerializeField] private NormalCheck blueBrinE;
  [SerializeField] private NormalCheck blueBrin;
  [SerializeField] private NormalCheck billymaze;
  [SerializeField] private NormalCheck betaPBs;
  [SerializeField] private NormalCheck behindAphlaPBs;
  [SerializeField] private NormalCheck firstmissle;
  [SerializeField] private NormalCheck pipe;
  [SerializeField] private NormalCheck xray;
  [SerializeField] private NormalCheck mainSteet;
  [SerializeField] private NormalCheck speedMainStreet;
  [SerializeField] private NormalCheck spazer;
  [SerializeField] private NormalCheck shak;
  [SerializeField] private NormalCheck vaira;
  [SerializeField] private NormalCheck kraidpbs;
  [SerializeField] private NormalCheck kraidE;
  [SerializeField] private NormalCheck crocE;
  [SerializeField] private NormalCheck bubblemountains;
  [SerializeField] private NormalCheck musket;
  [SerializeField] private NormalCheck jail;
  [SerializeField] private NormalCheck mickeymouse;
  [SerializeField] private NormalCheck firefeas;
  [SerializeField] private NormalCheck fireflys;
  [SerializeField] private NormalCheck jailmissle;
  [SerializeField] private NormalCheck speed;
  [SerializeField] private NormalCheck speedMissle;
  [SerializeField] private NormalCheck waveBeam;
  [SerializeField] private NormalCheck waveBeamMissle;
  [SerializeField] private NormalCheck uNresreve;
  [SerializeField] private NormalCheck bubbleLeft;
  [SerializeField] private NormalCheck lavaRoom;
  [SerializeField] private NormalCheck crumbleShaft;
  [SerializeField] private NormalCheck ice;
  [SerializeField] private NormalCheck hjBe;
  [SerializeField] private NormalCheck hjb;
  [SerializeField] private NormalCheck hjBmissles;
  [SerializeField] private NormalCheck pbShame;
  [SerializeField] private NormalCheck ridleyE;
  [SerializeField] private NormalCheck crocEscape;
  [SerializeField] private NormalCheck screw;
  [SerializeField] private NormalCheck gTblock;
  [SerializeField] private NormalCheck spaceGt;
  [SerializeField] private NormalCheck crocPBs;
  [SerializeField] private NormalCheck crocEtank;
  [SerializeField] private NormalCheck indy;
  [SerializeField] private NormalCheck grapple;
  [SerializeField] private NormalCheck backbackEarlySupers;

  [FormerlySerializedAs("AlphaPbs")] [SerializeField]
  private NormalCheck alphaPbs;

  //alttp checks
  [SerializeField] private NormalCheck hobo;
  [SerializeField] private NormalCheck darkdesertrock;
  [SerializeField] private NormalCheck darkdesertrock2;
  [SerializeField] private NormalCheck cave45;
  [SerializeField] private NormalCheck deserttablet;
  [SerializeField] private NormalCheck bumberledge;
  [SerializeField] private NormalCheck graveyardledge;
  [SerializeField] private NormalCheck pymidledge;
  [SerializeField] private NormalCheck catfish;
  [SerializeField] private NormalCheck darkmountian;
  [SerializeField] private NormalCheck darkmountain2;
  [SerializeField] private NormalCheck hypecave;
  [SerializeField] private NormalCheck island;
  [SerializeField] private NormalCheck backofgreenpendent;
  [SerializeField] private NormalCheck greenpendent;
  [SerializeField] private NormalCheck mushroom;
  [SerializeField] private NormalCheck waterfall;
  [SerializeField] private NormalCheck scam;
  [SerializeField] private NormalCheck spiralcave;
  [SerializeField] private NormalCheck lightmountain;
  [SerializeField] private NormalCheck lightleftside;
  [SerializeField] private NormalCheck lumberjack;
  [SerializeField] private NormalCheck mirrorleftside;
  [SerializeField] private NormalCheck desertcave;
  [SerializeField] private NormalCheck desertlegde;
  [SerializeField] private NormalCheck shovel;
  [SerializeField] private NormalCheck house;
  [SerializeField] private NormalCheck escape;
  [SerializeField] private NormalCheck uncle;
  [SerializeField] private NormalCheck bumbrock;
  [SerializeField] private NormalCheck lightsp;
  [SerializeField] private NormalCheck southsore;
  [SerializeField] private NormalCheck icerod;
  [SerializeField] private NormalCheck tabletmountain;
  [SerializeField] private NormalCheck race;
  [SerializeField] private NormalCheck bookshelf;
  [SerializeField] private NormalCheck bar;
  [SerializeField] private NormalCheck bottlekid;
  [SerializeField] private NormalCheck checkenhut;
  [SerializeField] private NormalCheck bottlevender;
  [SerializeField] private NormalCheck blindsden;
  [SerializeField] private NormalCheck well;
  [SerializeField] private NormalCheck smithy;
  [SerializeField] private NormalCheck magicbat;
  [SerializeField] private NormalCheck woods;
  [SerializeField] private NormalCheck woods2;
  [SerializeField] private NormalCheck pedastil;
  [SerializeField] private NormalCheck kingstomb;
  [SerializeField] private NormalCheck mountainisland;
  [SerializeField] private NormalCheck oldman;
  [SerializeField] private NormalCheck mountainrightbot;
  [SerializeField] private NormalCheck ttshed;
  [SerializeField] private NormalCheck smithchain;
  [SerializeField] private NormalCheck diggame;
  [SerializeField] private NormalCheck hypescave;
  [SerializeField] private NormalCheck hammerpegs;
  [SerializeField] private NormalCheck stumpy;
  [SerializeField] private NormalCheck pymidfairy;
  [SerializeField] private NormalCheck mario;
  [SerializeField] private NormalCheck chestgame;
  [SerializeField] private Dungeonchests eastern;
  [SerializeField] private Dungeonchests dp;
  [SerializeField] private Dungeonchests skull;
  [SerializeField] private Dungeonchests swamp;
  [SerializeField] private Dungeonchests toh;
  [SerializeField] private Dungeonchests tt;
  [SerializeField] private Dungeonchests pod;
  [SerializeField] private Dungeonchests icepal;
  [SerializeField] private Dungeonchests tr;
  [SerializeField] private Dungeonchests mm;
  [SerializeField] private Dungeonchests gt;
  [SerializeField] private NormalCheck aga1check;

  [SerializeField] private NormalCheck mimic;

  //Z1 checks
  [SerializeField] private NormalCheck oldman1;
  [SerializeField] private NormalCheck oldman2;
  [SerializeField] private NormalCheck oldmangrave;
  [SerializeField] private NormalCheck floatingboard;
  [SerializeField] private NormalCheck floatingboard2;
  [SerializeField] private NormalCheck undersolder;
  [SerializeField] private NormalCheck rafttakeitem;
  [SerializeField] private NormalCheck bombtakeany1;
  [SerializeField] private NormalCheck bombtakeany2;
  [SerializeField] private NormalCheck bushtakeany;

  [SerializeField] private NormalCheck notecheck;

  //z1 dungeon chaecks
  [SerializeField] private Reader d1a;
  [SerializeField] private Reader d1b;
  [SerializeField] private Reader d1c;
  [SerializeField] private Reader d1d;
  [SerializeField] private Reader d1e;
  [SerializeField] private Reader d1f;
  [SerializeField] private Reader d1h;
  [SerializeField] private Reader d1g;
  [SerializeField] private Reader d1i;
  [SerializeField] private Reader d1q;
  [SerializeField] private Reader d1Boss;
  [SerializeField] private Reader d2a;
  [SerializeField] private Reader d2b;
  [SerializeField] private Reader d2c;
  [SerializeField] private Reader d2d;
  [SerializeField] private Reader d2e;
  [SerializeField] private Reader d2f;
  [SerializeField] private Reader d2h;
  [SerializeField] private Reader d2g;
  [SerializeField] private Reader d2i;
  [SerializeField] private Reader d2q;
  [SerializeField] private Reader d2Boss;
  [SerializeField] private Reader d3a;
  [SerializeField] private Reader d3b;
  [SerializeField] private Reader d3c;
  [SerializeField] private Reader d3d;
  [SerializeField] private Reader d3e;
  [SerializeField] private Reader d3f;
  [SerializeField] private Reader d3h;
  [SerializeField] private Reader d3g;
  [SerializeField] private Reader d3i;
  [SerializeField] private Reader d3q;
  [SerializeField] private Reader d3x;
  [SerializeField] private Reader d3t;
  [SerializeField] private Reader d3Boss;
  [SerializeField] private Reader d4a;
  [SerializeField] private Reader d4b;
  [SerializeField] private Reader d4c;
  [SerializeField] private Reader d4d;
  [SerializeField] private Reader d4e;
  [SerializeField] private Reader d4f;
  [SerializeField] private Reader d4h;
  [SerializeField] private Reader d4Boss;
  [SerializeField] private Reader d5a;
  [SerializeField] private Reader d5b;
  [SerializeField] private Reader d5c;
  [SerializeField] private Reader d5d;
  [SerializeField] private Reader d5e;
  [SerializeField] private Reader d5f;
  [SerializeField] private Reader d5h;
  [SerializeField] private Reader d5g;
  [SerializeField] private Reader d5i;
  [SerializeField] private Reader d5q;
  [SerializeField] private Reader d5x;
  [SerializeField] private Reader d5t;
  [SerializeField] private Reader d5z;
  [SerializeField] private Reader d5Boss;
  [SerializeField] private Reader d6a;
  [SerializeField] private Reader d6c;
  [SerializeField] private Reader d6b;
  [SerializeField] private Reader d6d;
  [SerializeField] private Reader d6e;
  [SerializeField] private Reader d6f;
  [SerializeField] private Reader d6h;
  [SerializeField] private Reader d6g;
  [SerializeField] private Reader d6i;
  [SerializeField] private Reader d6q;
  [SerializeField] private Reader d6Boss;
  [SerializeField] private Reader d7a;
  [SerializeField] private Reader d7b;
  [SerializeField] private Reader d7c;
  [SerializeField] private Reader d7d;
  [SerializeField] private Reader d7e;
  [SerializeField] private Reader d7f;
  [SerializeField] private Reader d7h;
  [SerializeField] private Reader d7g;
  [SerializeField] private Reader d7i;
  [SerializeField] private Reader d7q;
  [SerializeField] private Reader d7x;
  [SerializeField] private Reader d7t;
  [SerializeField] private Reader d7z;
  [SerializeField] private Reader d7v;
  [SerializeField] private Reader d7y;
  [SerializeField] private Reader d7u;
  [SerializeField] private Reader d7s;
  [SerializeField] private Reader d7Boss;
  [SerializeField] private Reader d8a;
  [SerializeField] private Reader d8b;
  [SerializeField] private Reader d8c;
  [SerializeField] private Reader d8d;
  [SerializeField] private Reader d8e;
  [SerializeField] private Reader d8f;
  [SerializeField] private Reader d8h;
  [SerializeField] private Reader d8g;
  [SerializeField] private Reader d8i;
  [SerializeField] private Reader d8q;
  [SerializeField] private Reader d8x;
  [SerializeField] private Reader d8t;
  [SerializeField] private Reader d8z;
  [SerializeField] private Reader d8v;
  [SerializeField] private Reader d8y;
  [SerializeField] private Reader d8u;
  [SerializeField] private Reader d8Boss;
  [SerializeField] private NormalCheck m1morph;
  [SerializeField] private NormalCheck m1ceiling;
  [SerializeField] private NormalCheck m1firstmissle;
  [SerializeField] private NormalCheck m1kraidright1;
  [SerializeField] private NormalCheck m1kraidright2;
  [SerializeField] private NormalCheck m1kraidright3;
  [SerializeField] private NormalCheck m1kraide;
  [SerializeField] private NormalCheck m1kraidleft1;
  [SerializeField] private NormalCheck m1kraidleft2;
  [SerializeField] private NormalCheck m1longbeam;
  [SerializeField] private NormalCheck m1icebeam;
  [SerializeField] private NormalCheck m1bombs;
  [SerializeField] private NormalCheck m1varia;
  [SerializeField] private NormalCheck m1topmissles;
  [SerializeField] private NormalCheck m1topmissles2;
  [SerializeField] private NormalCheck m1norfairtopmissles;
  [SerializeField] private NormalCheck m1norfairtopmissles2;
  [SerializeField] private NormalCheck m1norfairmidmissles;
  [SerializeField] private NormalCheck m1norfairmidmissles2;
  [SerializeField] private NormalCheck m1norfairmidmissles3;
  [SerializeField] private NormalCheck m1norfairbotmissles;
  [SerializeField] private NormalCheck m1norfairleft1;
  [SerializeField] private NormalCheck m1norfairleft2;
  [SerializeField] private NormalCheck m1norfairmidbombs;
  [SerializeField] private NormalCheck m1norfairmidbombs2;
  [SerializeField] private NormalCheck m1norfairstartofhell;
  [SerializeField] private NormalCheck m1norfairstartofhell2;
  [SerializeField] private NormalCheck m1norfairstartofhell3;
  [SerializeField] private NormalCheck m1norfairstartofhell4;
  [SerializeField] private NormalCheck m1norfairstartofhell5;
  [SerializeField] private NormalCheck m1norfairstartofhell6;
  [SerializeField] private NormalCheck m1norfairstartofhell7;
  [SerializeField] private NormalCheck m1ridleyleft1;
  [SerializeField] private NormalCheck m1ridleyleft2;
  [SerializeField] private NormalCheck m1ridleyshowitem;
  [SerializeField] private NormalCheck m1ridleybehind;
  [SerializeField] private NormalCheck m1ridleybot;
  [SerializeField] private NormalCheck m1firste;



  private bool _canIbj;
  private bool _canBomb;
  private bool _canmorph;
  private bool _canDoHeatedRooms;
  private bool _canLightTorches;
  private bool _canMeltFreezors;
  private bool _canExtendMagic;
  private bool _canKillManyEnemies;
  private bool _canFly;
  private bool _canUsePowerBombs;
  private bool _canPassBombPassages;
  private bool _canDestroyBombWalls;
  private bool _canSpringBallJump;
  private bool _canHellRun;
  private bool _canOpenRedDoors;
  private bool _canBlueGateGlitch;
  private bool _canAccessDeathMountainPortal;
  private bool _canAccessDarkWorldPortal;
  private bool _canAccessMiseryMirePortal;
  private bool _canAccessNorfairUpperPortal;
  private bool _canAccessNorfairLowerPortal;
  private bool _canAccessMaridiaPortal;
  private bool _canEnterAndLeaveGauntlet;
  private bool _canAccessCrocomire;
  private bool _canOpenCathedralDoor;
  private bool _canOpenIceBeamDoor;
  private bool _canOpenMoatDoor;
  private bool _canOpenBombTorizoDoor;
  private bool _canOpenCrateriaSurfaceDoor;
  private bool _crateriaEast;
  private bool _canOpenWsDoor;
  private bool _phannyAccess;
  private bool _brinStarpinkAccess;
  private bool _brinstarRedAccess;
  private bool _brinStarKraidAccess;
  private bool _canReachAqueduct;
  private bool _canDefeatBotwoon;
  private bool _canDefeatDraygon;
  private bool _maridaOuterAcces;
  private bool _maridiaInnerAccess;


  //ItemBools
  private bool _tank1;
  private bool _tank2;
  private bool _tank3;
  private bool _tank4;
  private bool _tank5;
  private bool _missle5;
  private bool _missle10;
  private bool _super;
  private bool _super10;
  private bool _pb5;
  private bool _pb10;
  private bool _morphball;
  private bool _bombs;
  private bool _varia;
  private bool _gravity;
  private bool _chargeBeam;
  private bool _waveBeamItem;
  private bool _iceBeam;
  private bool _spazerBeam;
  private bool _plasmaBeam;
  private bool _springBall;
  private bool _spaceJump;
  private bool _hjboots;
  private bool _speedBoost;
  private bool _screwAttack;
  private bool _kraid;
  private bool _phanny;
  private bool _draygon;
  private bool _ridley;
  private bool _bowz3;
  private bool _hook;
  private bool _mushroom;
  private bool _powder;
  private bool _boots;
  private bool _firerod;
  private bool _icerod;
  private bool _bombos;
  private bool _ether;
  private bool _quake;
  private bool _glove1;
  private bool _glove2;
  private bool _lamp;
  private bool _hammer;
  private bool _flute;
  private bool _shovel;
  private bool _book;
  private bool _flip;
  private bool _bottle;
  private bool _redcane;
  private bool _bluecane;
  private bool _cape;
  private bool _mirror;
  private bool _pearl;
  private bool _sword1;
  private bool _sword2;
  private bool _m1Morph;
  private bool _m1Bombs;
  private bool _m1Hbj;
  private bool _m1Varia;
  private bool _m1Screw;
  private bool _m1LongBeam;
  private bool _m1IceBeam;
  private bool _m1WaveBeam;
  private bool _tri1;
  private bool _tri2;
  private bool _tri3;
  private bool _tri4;
  private bool _tri5;
  private bool _tri6;
  private bool _tri7;
  private bool _tri8;
  private bool _z1Bow;
  private bool _z1Book;
  private bool _z1Candle;
  private bool _z1Ladder;
  private bool _z1Meat;
  private bool _z1Power;
  private bool _z1Raft;
  private bool _z1Recorder;
  private bool _z1Wand;
  private bool _z1Wood;
  private bool _z1WhiteSword;
  private bool _z1MagicSword;
  private bool _halfMagic;
  private bool _aga1;
  private bool _grapple;
  private bool _canAccessNorfairUpperWest;
  private bool _canAccessNorfairUpperEast;
  private bool _cannorfairLowerWest;
  private int _pendentcount;
  private bool _greenpendent;
  private bool _darkworldaccess;
  private bool _darkworldNorthwestaccess;
  private bool _canAcessDarkWorldSouth;
  private ItemCount _crystalcount;
  private ItemCount _redcrystals;
  private bool _canAccessDarkWorldMire;
  private bool _canAccessLightworldMountain;
  private bool _canAccessDarkWorldMountainEast;
  private bool _traccess;
  private bool _mmaccess;
  private int _requriedcount;
  private bool _heart6;
  private bool _heart12;
  private bool _m1missle;
  private bool _z1bombs;
  private bool _canKillMostZ1Things;
  private bool _canKillBosses;
  private bool _canKillDarknuts;
  private bool _canKillGleeok;
  private bool _canKillPolsVoice;
  private bool _canKillWizzrobes;
  private bool _z1Airrows;



  public void ReadLogic()
  {
    if (_normalLogic.normalLogic == false)
    {
      return;
    }
      // Items Bools
      _tank1 = itemsFlags.IsItemAvailable("Tank1");
      _tank2 = itemsFlags.IsItemAvailable("Tank2");
      _tank3 = itemsFlags.IsItemAvailable("Tank3");
      _tank4 = itemsFlags.IsItemAvailable("Tank4");
      _tank5 = itemsFlags.IsItemAvailable("Tank5");
      _missle5 = itemsFlags.IsItemAvailable("Missles 5");
      _missle10 = itemsFlags.IsItemAvailable("Missles 10");
      _super = itemsFlags.IsItemAvailable("Super");
      _super10 = itemsFlags.IsItemAvailable("Super10");
      _pb5 = itemsFlags.IsItemAvailable("Pb 5");
      _pb10 = itemsFlags.IsItemAvailable("Pb 10");
      _morphball = itemsFlags.IsItemAvailable("Morph");
      _bombs = itemsFlags.IsItemAvailable("Bombs");
      _varia = itemsFlags.IsItemAvailable("Varia");
      _gravity = itemsFlags.IsItemAvailable("Grav");
      _chargeBeam = itemsFlags.IsItemAvailable("Charge");
      _waveBeamItem = itemsFlags.IsItemAvailable("Wave");
      _iceBeam = itemsFlags.IsItemAvailable("Ice");
      _spazerBeam = itemsFlags.IsItemAvailable("Spazer");
      _plasmaBeam = itemsFlags.IsItemAvailable("Plasma");
      _springBall = itemsFlags.IsItemAvailable("Spring");
      _spaceJump = itemsFlags.IsItemAvailable("Spacejump");
      _hjboots = itemsFlags.IsItemAvailable("Hjb");
      _speedBoost = itemsFlags.IsItemAvailable("Speed");
      _screwAttack = itemsFlags.IsItemAvailable("Screw");
      _grapple = itemsFlags.IsItemAvailable("Grapple");
      _kraid = itemsFlags.IsItemAvailable("Kraid");
      _phanny = itemsFlags.IsItemAvailable("Phanny");
      _draygon = itemsFlags.IsItemAvailable("Draygon");
      _ridley = itemsFlags.IsItemAvailable("Ridley");

      // Attlp
      _bowz3 = itemsFlags.IsItemAvailable("Bow");
      _hook = itemsFlags.IsItemAvailable("Hook");
      _mushroom = itemsFlags.IsItemAvailable("Mushrrom");
      _powder = itemsFlags.IsItemAvailable("Powder");
      _boots = itemsFlags.IsItemAvailable("Boots");
      _firerod = itemsFlags.IsItemAvailable("FireRod");
      _icerod = itemsFlags.IsItemAvailable("IceRod");
      _bombos = itemsFlags.IsItemAvailable("Bombos");
      _ether = itemsFlags.IsItemAvailable("Ether");
      _quake = itemsFlags.IsItemAvailable("Quake");
      _glove1 = itemsFlags.IsItemAvailable("Glove1");
      _glove2 = itemsFlags.IsItemAvailable("Glove2");
      _lamp = itemsFlags.IsItemAvailable("Lamp");
      _hammer = itemsFlags.IsItemAvailable("Hammer");
      _flute = itemsFlags.IsItemAvailable("Flute");
      _shovel = itemsFlags.IsItemAvailable("Shovel");
      _book = itemsFlags.IsItemAvailable("Book");
      _flip = itemsFlags.IsItemAvailable("Flips");
      _bottle = itemsFlags.IsItemAvailable("Bottle");
      _redcane = itemsFlags.IsItemAvailable("Redcane");
      _bluecane = itemsFlags.IsItemAvailable("Bluecane");
      _cape = itemsFlags.IsItemAvailable("Cape");
      _mirror = itemsFlags.IsItemAvailable("Mirror");
      _pearl = itemsFlags.IsItemAvailable("Pearl");
      _sword1 = itemsFlags.IsItemAvailable("Sword");
      _sword2 = itemsFlags.IsItemAvailable("MasterSword");
      _halfMagic = itemsFlags.IsItemAvailable("HalfMagic");
      _aga1 = itemsFlags.IsItemAvailable("Aga1");
      _greenpendent = itemsFlags.IsItemAvailable("GreenPendent");
      _pendentcount = itemsFlags.pendent.itemcount;
      _crystalcount = itemsFlags.crystals;
      _redcrystals = itemsFlags.redcrystals;
      _requriedcount = itemsFlags.requiredz3.itemcount;
      _mmaccess = itemsFlags.IsItemAvailable("MMaccess");
      _traccess = itemsFlags.IsItemAvailable("TRaccess");

      //M1 Items

      _m1Morph = itemsFlags.IsItemAvailable("M1Morph");
      _m1Bombs = itemsFlags.IsItemAvailable("M1Bombs");
      _m1Hbj = itemsFlags.IsItemAvailable("M1HiGHJUMP");
      _m1Varia = itemsFlags.IsItemAvailable("M1Varia");
      _m1Screw = itemsFlags.IsItemAvailable("M1Screw");
      _m1LongBeam = itemsFlags.IsItemAvailable("M1LongBeam");
      _m1IceBeam = itemsFlags.IsItemAvailable("M1Ice");
      _m1WaveBeam = itemsFlags.IsItemAvailable("M1Wave");
      _m1missle = itemsFlags.IsItemAvailable("M1Missles");

      // Z1 items 

      _heart6 = itemsFlags.IsItemAvailable("Heart6");
      _heart12 = itemsFlags.IsItemAvailable("Heart12");
      _tri1 = itemsFlags.IsItemAvailable("tri1");
      _tri2 = itemsFlags.IsItemAvailable("tri2");
      _tri3 = itemsFlags.IsItemAvailable("tri3");
      _tri4 = itemsFlags.IsItemAvailable("tri4");
      _tri5 = itemsFlags.IsItemAvailable("tri5");
      _tri6 = itemsFlags.IsItemAvailable("tri6");
      _tri7 = itemsFlags.IsItemAvailable("tri7");
      _tri8 = itemsFlags.IsItemAvailable("tri8");
      _z1Bow = itemsFlags.IsItemAvailable("Z1Bow");
      _z1Book = itemsFlags.IsItemAvailable("Book");
      _z1Candle = itemsFlags.IsItemAvailable("Z1Candle");
      _z1Ladder = itemsFlags.IsItemAvailable("Z1Ladder");
      _z1Meat = itemsFlags.IsItemAvailable("Z1Meat");
      _z1Power = itemsFlags.IsItemAvailable("Z1PowerBraclets");
      _z1Raft = itemsFlags.IsItemAvailable("Z1Raft");
      _z1Recorder = itemsFlags.IsItemAvailable("Z1Recorder");
      _z1Wand = itemsFlags.IsItemAvailable("Z1Wand");
      _z1Wood = itemsFlags.IsItemAvailable("Z1WoodSword");
      _z1WhiteSword = itemsFlags.IsItemAvailable("Z1WhiteSword");
      _z1MagicSword = itemsFlags.IsItemAvailable("Z1MagicSword");
      _z1bombs = itemsFlags.IsItemAvailable("Z1Bombs");
      _z1Airrows = itemsFlags.IsItemAvailable("Z1airrows");



      // LTTP logic

      _canLightTorches = _firerod && _lamp;
      _canMeltFreezors = _firerod || (_bombos && _sword1);
      _canExtendMagic = _halfMagic || _bottle;
      _canKillManyEnemies = (_sword1 || _hammer || _bowz3 || _firerod || _redcane) ||
                            (_bluecane && _canExtendMagic);

      // SM logic

      _canIbj = _morphball && _bombs;
      _canFly = _spaceJump;

      _canUsePowerBombs = (_morphball && _pb5);
      _canPassBombPassages = (_morphball && _bombs) ||
                             (_morphball && _pb5);
      _canDestroyBombWalls = _screwAttack || _canPassBombPassages;
      _canSpringBallJump = _morphball && _springBall;
      _canHellRun = (_varia || _tank5);
      _canOpenRedDoors = _missle5 || _super;
      _canBlueGateGlitch = _missle5 || _super || _waveBeamItem;
      _canAccessDeathMountainPortal = (_speedBoost && _super && _morphball) ||
                                      (_canDestroyBombWalls && _morphball && _super);
      _canAccessDarkWorldPortal =
        (_canUsePowerBombs && _super && _speedBoost && _gravity);
      /* "[hard],@CardMaridiaL1,@CardMaridiaL2,@CanUsePowerBombs,super,charge,gravity,ice",
       "[hard],@CardMaridiaL1,@CardMaridiaL2,@CanUsePowerBombs,super,charge,gravity,speed",
       "[hard],@CardMaridiaL1,@CardMaridiaL2,@CanUsePowerBombs,super,charge,hijump,ice,grapple",
       "[hard],@CardMaridiaL1,@CardMaridiaL2,@CanUsePowerBombs,super,missile,gravity,ice",
       "[hard],@CardMaridiaL1,@CardMaridiaL2,@CanUsePowerBombs,super,missile,gravity,speed",
       "[hard],@CardMaridiaL1,@CardMaridiaL2,@CanUsePowerBombs,super,missile,hijump,ice,grapple"
     ]*/
      _canAccessMiseryMirePortal = _canUsePowerBombs && _speedBoost && _varia && _gravity && _super && _spaceJump;


      /* "[hard],speed,varia,super,gravity,@CanUsePowerBombs",
       "[hard],speed,varia,super,hijump,@CanUsePowerBombs",
       "[hard],@CardNorfairL2,varia,super,hijump,@CanUsePowerBombs",
       "[hard],@CardNorfairL2,varia,super,@CanFly,gravity,@CanUsePowerBombs",
       "[hard],@CardNorfairL2,varia,super,@CanSpringBallJump,gravity,@CanUsePowerBombs",
       "[hard],@CardNorfairL2,varia,super,ice,gravity,@CanUsePowerBombs"
     ]*/
      _canAccessNorfairUpperPortal = _flute || (_glove1 && _lamp);
      _canAccessNorfairLowerPortal = _flute && _glove2;
      _canAccessMaridiaPortal = (_pearl && _flip && _gravity && _morphball && _aga1)
                                || (_pearl && _flip && _gravity && _morphball && _hammer && _glove1)
                                || (_pearl && _flip && _gravity && _morphball && _glove2);


      /* "[hard],pearl,flippers,morph,@CanSpringBallJump,aga1",
       "[hard],pearl,flippers,morph,@CanSpringBallJump,hammer,lift1",
       "[hard],pearl,flippers,morph,@CanSpringBallJump,lift2",
       "[hard],pearl,flippers,morph,hijump,aga1",
       "[hard],pearl,flippers,morph,hijump,hammer,lift1",
       "[hard],pearl,flippers,morph,hijump,lift2",
     ]*/
      _canReachAqueduct = _canAccessMaridiaPortal ||
                          _speedBoost || _grapple || _canIbj || _spaceJump;

      /*
                          "[hard],@CardMaridiaL1,gravity",
                           "[hard],@CardMaridiaL1,hijump,ice,grapple",
                          "[hard],@CardMaridiaL1,hijump,@CanSpringBallJump,grapple"
                          */
      _canDefeatBotwoon = _gravity && (_canAccessMaridiaPortal ||
                                       _speedBoost || _iceBeam);
      /*
                "[hard],ice",
           "[hard],speed,gravity",
           */

      _canDefeatDraygon = (_canDefeatBotwoon && _gravity) || (_canAccessMaridiaPortal && _gravity);


      /*


           "normal,@CardMaridiaL1,@CardMaridiaL2,@CanDefeatBotwoon,@CardMaridiaBoss,gravity,speed,hijump",
           "normal,@CardMaridiaL1,@CardMaridiaL2,@CanDefeatBotwoon,@CardMaridiaBoss,gravity,@CanFly",
           "normal,@CanAccessMaridiaPortal,@CardMaridiaBoss,gravity,speed,hijump",
           "normal,@CanAccessMaridiaPortal,@CardMaridiaBoss,gravity,@CanFly",

           "[hard],@CardMaridiaL1,@CardMaridiaL2,@CanDefeatBotwoon,@CardMaridiaBoss,gravity",
           "[hard],@CanAccessMaridiaPortal,@CardMaridiaBoss,gravity"
        */


      _maridaOuterAcces = _gravity &&
                          (_canUsePowerBombs || (_canAccessMaridiaPortal && (_screwAttack || _canPassBombPassages)));
/*
          "[hard],@Norfair Upper West,@CanUsePowerBombs,gravity",
          "[hard],@Norfair Upper West,@CanUsePowerBombs,hijump,@CanSpringBallJump",
          "[hard],@Norfair Upper West,@CanUsePowerBombs,hijump,ice",
          "[hard],@CanAccessMaridiaPortal,@CardMaridiaL1,@CardMaridiaL2,@CanPassBombPassages",
          "[hard],@CanAccessMaridiaPortal,@CardMaridiaL1,@CardMaridiaL2,gravity,screw",
          "[hard],@CanAccessMaridiaPortal,@CardMaridiaL1,@CardMaridiaL2,super,gravity",
          "[hard],@CanAccessMaridiaPortal,@CardMaridiaL1,@CardMaridiaL2,super,hijump,@CanSpringBallJump",
          "[hard],@CanAccessMaridiaPortal,@CardMaridiaL1,@CardMaridiaL2,super,hijump,ice"
  */
      _maridiaInnerAccess = (_gravity && _canUsePowerBombs && _spaceJump && _super)
                            || (_gravity && _canUsePowerBombs && _canIbj && _super)
                            || (_canUsePowerBombs && _speedBoost && _super && _gravity)
                            || (_canUsePowerBombs && _gravity && _grapple && _super)
                            || (_gravity && _canAccessMaridiaPortal);
      /*
              "[hard],super,@Norfair Upper West,@CanUsePowerBombs,gravity",
              "[hard],super,@Norfair Upper West,@CanUsePowerBombs,hijump,ice,grapple",
              "[hard],super,@Norfair Upper West,@CanUsePowerBombs,hijump,@CanSpringBallJump,grapple",
              "[hard],@CanAccessMaridiaPortal"
              */


      // SM Cat Items

      _canEnterAndLeaveGauntlet = (_morphball && _canIbj)
                                  || (_pb10 && _spaceJump &&
                                      _canUsePowerBombs)
                                  || (_morphball && _screwAttack && _spaceJump)
                                  || (_morphball && _screwAttack && _canIbj)
                                  || (_morphball && _speedBoost && _canIbj)
                                  || (_morphball && _speedBoost && _pb10 && _canUsePowerBombs)
                                  || (_morphball && _speedBoost && _screwAttack);
      /*  "[hard],@CardCrateriaL1,morph,bomb",
        "[hard],@CardCrateriaL1,morph,powerbomb:10",
        "[hard],@CardCrateriaL1,screw",
        "[hard],@CardCrateriaL1,speed,@CanUsePowerBombs,alltanks:2"
      ]*/

      //Doors

      _canOpenCrateriaSurfaceDoor = _canUsePowerBombs;
      _canOpenBombTorizoDoor = _canOpenRedDoors;
      _canOpenMoatDoor = _canUsePowerBombs;
      _canOpenIceBeamDoor = _super;
      _canOpenCathedralDoor = _super;
      _canAccessCrocomire = _super;
      _canOpenWsDoor = _super;


      //AreaAccess
      _crateriaEast = (_canUsePowerBombs && _super)
                      || (_canOpenMoatDoor && _canAccessNorfairUpperPortal && _canUsePowerBombs &&
                          _iceBeam)
                      || (_canOpenMoatDoor && _canAccessNorfairUpperPortal && _canUsePowerBombs &&
                          _hjboots)
                      || (_canUsePowerBombs && _gravity && _super)
                      || (_canOpenMoatDoor && _canAccessNorfairUpperPortal && _canUsePowerBombs &&
                          _spaceJump)
                      || (_canAccessMaridiaPortal && _canDestroyBombWalls &&
                          _gravity && _super)
                      || (_canAccessMaridiaPortal &&
                          _gravity && _super && _draygon);
      /*
      "[hard],@CanOpenMoatDoor,@CanAccessNorfairUpperPortal,@CanUsePowerBombs,@CanFly",
      "[hard],@CanOpenMoatDoor,@CanAccessNorfairUpperPortal,@CanUsePowerBombs,@CanSpringBallJump",
      "[hard],@CanAccessMaridiaPortal,@CardMaridiaL2,super,hijump,@CanPassBombPassages",
      "[hard],@CanAccessMaridiaPortal,@CardMaridiaL2,super,gravity,@CanDestroyBombWalls",
      "[hard],@CanAccessMaridiaPortal,gravity,draygon",
      "[hard],@CanUsePowerBombs,super,hijump,ice,grapple,@CardMaridiaL1",
      "[hard],@CanUsePowerBombs,super,hijump,@CanSpringBallJump,grapple,@CardMaridiaL1"
        ],*/

      _brinStarpinkAccess = _canUsePowerBombs
                            || (_canOpenRedDoors && _canDestroyBombWalls)
                            || (_canOpenRedDoors && _speedBoost)
                            || (_canAccessNorfairUpperPortal && _morphball && _waveBeamItem && _iceBeam)
                            || (_canAccessNorfairUpperPortal && _morphball && _waveBeamItem && _hjboots)
                            || (_canAccessNorfairUpperPortal && _morphball && _waveBeamItem && _spaceJump);
      /*

                "[hard],@CanAccessNorfairUpperPortal,morph,@CanOpenRedDoors,ice",
                "[hard],@CanAccessNorfairUpperPortal,morph,@CanOpenRedDoors,hijump",
                "[hard],@CanAccessNorfairUpperPortal,morph,@CanOpenRedDoors,@CanSpringBallJump",
                "[hard],@CanAccessNorfairUpperPortal,morph,@CanOpenRedDoors,@CanFly",
                "[hard],@CanAccessNorfairUpperPortal,morph,wave,@CanSpringBallJump",
                "[hard],@CanAccessNorfairUpperPortal,morph,wave,@CanFly"
        */
      _brinstarRedAccess = (_canDestroyBombWalls && _super && _morphball)
                           || (_speedBoost && _super && _morphball)
                           || (_canAccessNorfairLowerPortal && _iceBeam)
                           || (_canAccessNorfairUpperPortal && _hjboots)
                           || (_canAccessNorfairUpperPortal && _morphball && _waveBeamItem && _spaceJump)
                           || (_canIbj && _canAccessNorfairUpperPortal)
                           || (_spaceJump && _canAccessNorfairUpperPortal);

      _brinStarKraidAccess = (_canPassBombPassages && _super && _canDestroyBombWalls)
                             || (_super && _speedBoost && _canPassBombPassages)
                             || (_canPassBombPassages && _canAccessNorfairUpperPortal &&
                                 _super);
      /*  } "name": "CanExitThroughUpperNorfair",
                "access_rules": [
                  "normal,@CardLowerNorfairL1,@CardNorfairL2",
                  "normal,gravity,@CardNorfairL2",
                  "normal,gravity,wave,grapple",
                  "normal,gravity,wave,space",

                  "[hard],@CardNorfairL2",
                  "[hard],speed",
                  "[hard],@CanFly",
                  "[hard],grapple",
                  "[hard],hijump,@CanSpringBallJump",
                  "[hard],hijump,ice"
                ]
              },
              {
                "name": "CanExitThroughPortal",
                "access_rules": [
                  "normal,@CanUsePowerBombs,space,super",
                  "normal,@CanUsePowerBombs,space,charge",

                  "[hard],@CanUsePowerBombs"
                ]
              },
              {
                "name": "CanExitLowerNorfairEast",
                "access_rules": [
                  "normal,morph,@CardNorfairL2",
                  "normal,morph,gravity,wave,grapple",
                  "normal,morph,gravity,wave,space",

                  "[hard],morph,@CardNorfairL2",
                  "[hard],morph,@CanBlueGateGlitch,speed",
                  "[hard],morph,@CanBlueGateGlitch,@CanFly",
                  "[hard],morph,@CanBlueGateGlitch,grapple",
                  "[hard],morph,@CanBlueGateGlitch,hijump,@CanSpringBallJump",
                  "[hard],morph,@CanBlueGateGlitch,hijump,ice",
                  "[hard],alltanks:5"
                ]
              },*/
      // "[hard],@CanAccessNorfairUpperPortal,@CanSpringBallJump",
      _phannyAccess = _crateriaEast && _canOpenWsDoor && _canPassBombPassages;

      // Crateira Checks
      //BT
      if (_canOpenRedDoors && _morphball)
      {
        bt.SetNormal("yellow");
        if (_canPassBombPassages)
        {
          bt.SetNormal("green");
        }
      }
      else
      {
        bt.SetNormal("red");
      }

      //Climb Supers

      if (_canUsePowerBombs && _speedBoost && _iceBeam)
      {
        climbSupers.SetNormal("green");
      }
      else if (_canUsePowerBombs && _speedBoost)
      {
        climbSupers.SetNormal("yellow");
      }
      else
      {
        climbSupers.SetNormal("red");
      }

      //230 missle
      if (_canPassBombPassages)
      {
        missle230.SetNormal("green");
      }
      else
      {
        missle230.SetNormal("red");
      }

      //OldMB
      // Terminator
      if (_canDestroyBombWalls)
      {
        oldMb.SetNormal("green");
        terminator.SetNormal("green");
      }
      else
      {
        oldMb.SetNormal("red");
        terminator.SetNormal("red");
      }

      // ShipPbs
      if (_canUsePowerBombs && (_speedBoost || _spaceJump || _canIbj))
      {
        shipPBs.SetNormal("green");
      }
      else
      {
        shipPBs.SetNormal("red");
      }

      // Gauntlet

      if (_canEnterAndLeaveGauntlet)
      {
        gauntlet.SetNormal("yellow");

        if (itemsFlags.IsItemAvailable("tank1"))
        {
          gauntlet.SetNormal("green");
        }
      }
      else
      {
        gauntlet.SetNormal("red");
      }

      if (itemsFlags.IsItemsAvailable(new[] { "Speed", "tank2" }) ||
          itemsFlags.IsItemsAvailable(new[] { "Morph", "Pb 5" }))
      {
        gauntlet.SetNormal("yellow");
      }




      // Back of Gauntlet

      if (_canEnterAndLeaveGauntlet && _canPassBombPassages)
      {
        backGauntlet.SetNormal("yellow");
        if (itemsFlags.IsItemAvailable("tank2"))
        {
          backGauntlet.SetNormal("green");
        }
      }
      else
      {
        backGauntlet.SetNormal("red");
      }

      // moat access
      if (_crateriaEast)
      {
        cwj.SetNormal("green");

        //after moat cave
        if (_morphball && _canOpenWsDoor)
        {
          cAve.SetNormal("yellow");
          // topWS outside
          if (_phannyAccess)
          {
            toptopWs.SetNormal("yellow");
            wStopCave.SetNormal("yellow");
          }

        }

        if (itemsFlags.IsItemsAvailable(new[] { "Morph", "Speed" })
            || itemsFlags.IsItemsAvailable(new[] { "Morph", "Grapple" })
            || itemsFlags.IsItemsAvailable(new[] { "Morph", "Spacejump" })
            || itemsFlags.IsItemsAvailable(new[] { "Morph", "Grav" }) && _canIbj
            || itemsFlags.IsItemsAvailable(new[] { "Morph", "Grav", "hjb" }))
        {
          cAve.SetNormal("green");

          if (_phannyAccess)
          {
            toptopWs.SetNormal("green");
            wStopCave.SetNormal("green");
          }
        }

      }
      else
      {
        cAve.SetNormal("red");
        toptopWs.SetNormal("red");
        wStopCave.SetNormal("red");
        cwj.SetNormal("red");
      }
      //WS Checks
      // "Missile (Wrecked Ship middle)"
      // rightside super 
      // left side super
      // robots 

      if (_phannyAccess)
      {
        if (_canPassBombPassages)
        {
          wSmissles.SetNormal("green");
          rightsidesuper.SetNormal("green");
          leftsidesuper.SetNormal("green");
          robots.SetNormal("green");
        }
      }

      else
      {
        wSmissles.SetNormal("red");
        rightsidesuper.SetNormal("red");
        leftsidesuper.SetNormal("red");
        robots.SetNormal("red");
        backWs.SetNormal("red");
      }

      //back of WS
      if (_phannyAccess && (_spaceJump || _speedBoost || _hjboots || _gravity))
      {
        backWs.SetNormal("green");
      }

      if (_phannyAccess && (_canPassBombPassages || _springBall))
      {
        backWs.SetNormal("yellow");
      }
      else
      {
        backWs.SetNormal("red");
      }

      //"Reserve Tank, Wrecked Ship"
      //"name": "Gravity Suit", "name":
      //"Missile (Gravity Suit)",
      if (_phannyAccess && _canUsePowerBombs && (_grapple || _tank3 || _spaceJump) || (_varia && _tank2))
      {
        grav.SetNormal("green");
        fireflys.SetNormal("green");

        if (itemsFlags.IsItemAvailable("Speed"))
        {
          wSspeed.SetNormal("green");
        }
        else
        {
          wSspeed.SetNormal("blue");
        }


      }
      else
      {
        wSspeed.SetNormal("red");
        grav.SetNormal("red");
        fireflys.SetNormal("red");
      }
      /*
                     "[hard],@CanUnlockShip,@CardWreckedShipL1,@CanUsePowerBombs,speed,varia",
                     "[hard],@CanUnlockShip,@CardWreckedShipL1,@CanUsePowerBombs,speed,alltanks:2",
                     "access_rules": [
                      "normal,@CanUnlockShip,@CardWreckedShipL1,grapple",
                      "normal,@CanUnlockShip,@CardWreckedShipL1,space",
                     "normal,@CanUnlockShip,@CardWreckedShipL1,varia,alltanks:2",
                     ormal,@CanUnlockShip,@CardWreckedShipL1,alltanks:3",
                     "[hard],@CanUnlockShip,@CardWreckedShipL1,varia",
                      "[hard],@CanUnlockShip,@CardWreckedShipL1,alltanks:1"
                      "[hard],@CanUnlockShip,@CardWreckedShipL1,alltanks:1"
      */


      //"name": "Brinstar Blue",
      morph.SetNormal("green");
      // firstmissles
      //bluebrin
      blueBrinE.SetNormal("yellow");

      if (_morphball)
      {
        firstmissle.SetNormal("green");
        blueBrin.SetNormal("green");
      }
      else
      {
        firstmissle.SetNormal("red");
        blueBrin.SetNormal("red");
      }

      if (_canUsePowerBombs)
      {
        leftofMorph.SetNormal("green");
        billymaze.SetNormal("green");
      }
      else
      {
        leftofMorph.SetNormal("red");
        billymaze.SetNormal("red");
      }

      if (_hjboots || _speedBoost || _iceBeam || _canFly)
      {
        blueBrinE.SetNormal("green");
      }
      else
      {
        blueBrinE.SetNormal("yellow");
      }

      // Green BrinStar

      if (_canDestroyBombWalls || _speedBoost)
      {
        if (_morphball && _canOpenRedDoors)
        {
          brinResevre.SetNormal("yellow");
          backofEarlySupers.SetNormal("yellow");
          brigde.SetNormal("yellow");
          earlySuper.SetNormal("yellow");
          if (_canUsePowerBombs)
          {
            brigde.SetNormal("green");
            backbackEarlySupers.SetNormal("yellow");

          }
        }

        if (_canUsePowerBombs)
        {
          etttcoonsE.SetNormal("green");
          etttcoonsPb.SetNormal("green");
          if (itemsFlags.IsItemAvailable("Super"))
          {
            etttcoonssuper.SetNormal("green");
          }
        }

        if (_speedBoost)
        {
          brinResevre.SetNormal("green");
          if (_morphball)
          {
            backofEarlySupers.SetNormal("green");
            earlySuper.SetNormal("green");

            if (_canUsePowerBombs)
            {
              backbackEarlySupers.SetNormal("green");

            }
          }
        }
      }
      else
      {
        etttcoonssuper.SetNormal("red");
        earlySuper.SetNormal("red");
        backbackEarlySupers.SetNormal("red");
        backofEarlySupers.SetNormal("red");
        etttcoonsE.SetNormal("red");
        etttcoonsPb.SetNormal("red");
        brigde.SetNormal("red");
        brinResevre.SetNormal("red");
      }

      //"name": "Brinstar Pink

      if (_brinStarpinkAccess)
      {
        bigpink.SetNormal("green");
        bigpink2.SetNormal("green");

        if (_canPassBombPassages)
        {
          charge.SetNormal("green");
          if (_canPassBombPassages && _super)
          {
            spospo.SetNormal("green");
          }
          else
          {
            spospo.SetNormal("red");
          }
        }
        else
        {
          charge.SetNormal("red");
        }

        if (_canUsePowerBombs && _speedBoost)
        {
          waterway.SetNormal("green");
        }
        else
        {
          waterway.SetNormal("red");
        }

        if ((_canUsePowerBombs)
            || (_morphball && _super)
            || (_morphball && _canAccessNorfairUpperPortal))
        {
          pipe.SetNormal("green");
        }
        else
        {
          pipe.SetNormal("red");
        }

        if (_canUsePowerBombs)
        {
          if (_super)
          {

            mission.SetNormal("green");
            if (_waveBeamItem)
            {
              waveGate.SetNormal("green");
            }
            else
            {
              waveGate.SetNormal("yellow");
            }
          }
          else
          {
            mission.SetNormal("red");
          }





        }


      }
      else
      {
        bigpink.SetNormal("red");
        bigpink2.SetNormal("red");
        waveGate.SetNormal("red");
        mission.SetNormal("red");
        waterway.SetNormal("red");
        spospo.SetNormal("red");
        charge.SetNormal("red");
        pipe.SetNormal("red");
      }
      //"name": "Brinstar Red",

      if (_brinstarRedAccess)
      {

        if (_super)
        {
          alphaPbs.SetNormal("green");
          if (_canPassBombPassages)
          {
            spazer.SetNormal("green");
          }

          if (_canUsePowerBombs)
          {
            betaPBs.SetNormal("green");
            behindAphlaPBs.SetNormal("green");
            xray.SetNormal("yellow");
          }
        }

        if (_canUsePowerBombs && _canOpenRedDoors)
        {
          if ((itemsFlags.IsItemsAvailable(new[] { "varia", "tank3" }) && _canIbj)
              || (itemsFlags.IsItemAvailable("tank5") && _canIbj)
              || itemsFlags.IsItemsAvailable(new[] { "Hjb", "Speed", "varia", "tank3" })
              || itemsFlags.IsItemsAvailable(new[] { "Hjb", "Speed", "tank5" })
              || itemsFlags.IsItemsAvailable(new[] { "Spring", "varia", "tank3" })
              || itemsFlags.IsItemsAvailable(new[] { "Spring", "tank5" }))
          {
            xray.SetNormal("yellow");
          }

          if (_spaceJump && _grapple)
          {
            xray.SetNormal("green");
          }
        }
        else
        {
          xray.SetNormal("red");
        }

      }
      else
      {
        alphaPbs.SetNormal("red");
        betaPBs.SetNormal("red");
        spazer.SetNormal("red");
        behindAphlaPBs.SetNormal("red");
        xray.SetNormal("red");
      }

      if (_brinStarKraidAccess)
      {
        vaira.SetNormal("green");
        kraidE.SetNormal("green");

        if (_canUsePowerBombs)
        {
          kraidpbs.SetNormal("green");
        }
      }
      else
      {
        vaira.SetNormal("red");
        kraidpbs.SetNormal("red");
        kraidE.SetNormal("red");
      }

      if (_maridaOuterAcces)
      {
        mainSteet.SetNormal("green");
        if (_canOpenRedDoors)
        {
          mamatSide.SetNormal("green");
        }

        if (_speedBoost)
        {
          speedMainStreet.SetNormal("green");
        }
        else
        {
          speedMainStreet.SetNormal("red");
        }

        if (_canOpenRedDoors && (_speedBoost || _grapple || _canFly || _canIbj))
        {
          mamaT.SetNormal("green");
        }
        else if (_canOpenRedDoors && _hjboots && _canSpringBallJump
                 || (_canOpenRedDoors && _gravity && _canSpringBallJump))
        {
          mamaT.SetNormal("yellow");
        }
        else
        {
          mamaT.SetNormal("red");
        }


        if (_canPassBombPassages && _canReachAqueduct && (_hjboots && _iceBeam
                                                          || _hjboots && _springBall))
        {
          waterhole.SetNormal("yellow");
          beach.SetNormal("yellow");
        }


        // Shak
        if (_canOpenRedDoors && _gravity)
        {
          if (_iceBeam)
          {
            shak.SetNormal("yellow");
          }

          else if (_grapple)
          {
            if (_spaceJump || _hjboots || _canIbj)
            {
              shak.SetNormal("green");
            }
            else
            {
              shak.SetNormal("red");
            }
          }
          else
          {
            shak.SetNormal("red");
          }
        }
      }
      else
      {
        speedMainStreet.SetNormal("red");
        mainSteet.SetNormal("red");
        mamaT.SetNormal("red");
        mamatSide.SetNormal("red");
        shak.SetNormal("red");
      }


      if (_maridiaInnerAccess)
      {

        if (_canReachAqueduct && _hjboots && _super)
        {
          sandpitRight1.SetNormal("yellow");
          if (_canSpringBallJump)
          {
            sandpitRight2.SetNormal("yellow");
          }

          if (_spaceJump)
          {
            sandpitleft.SetNormal("yellow");
          }
        }

        if (_canPassBombPassages && _canReachAqueduct && _gravity)
        {
          waterhole.SetNormal("green");
          beach.SetNormal("green");
        }
        else
        {
          waterhole.SetNormal("red");
          beach.SetNormal("red");
        }

        if (_canReachAqueduct && _super)
        {
          sandpitRight1.SetNormal("green");
          sandpitRight2.SetNormal("green");

          if (_canPassBombPassages)
          {
            sandpitleft.SetNormal("green");
          }
          else
          {
            sandpitleft.SetNormal("red");
          }
        }
        else
        {
          sandpitRight1.SetNormal("red");
          sandpitRight2.SetNormal("red");
        }


        if (_canReachAqueduct && _gravity && _speedBoost)
        {
          aquaDuct1.SetNormal("green");
          aquaDuct2.SetNormal("green");
        }
        else if (_canReachAqueduct && _gravity)
        {
          aquaDuct1.SetNormal("yellow");
          aquaDuct2.SetNormal("yellow");
        }
        else
        {
          aquaDuct2.SetNormal("red");
          aquaDuct1.SetNormal("red");
        }

        if (_canDefeatBotwoon || _canAccessMaridiaPortal)
        {
          botwoonE.SetNormal("yellow");
          if (_gravity)
          {

            if (_speedBoost || _canAccessMaridiaPortal)
            {
              botwoonE.SetNormal("green");
              draymissle.SetNormal("green");
            }
            else
            {
              draymissle.SetNormal("yellow");
            }
          }
          else
          {
            draymissle.SetNormal("red");
          }

        }
        else
        {
          draymissle.SetNormal("red");
          botwoonE.SetNormal("red");
        }

        if (_canDefeatDraygon)
        {
          space.SetNormal("yellow");
          if (_speedBoost)
          {
            space.SetNormal("green");
          }
          else
          {
            space.SetNormal("yellow");
          }

          if (_canAccessMaridiaPortal && _canFly)
          {
            space.SetNormal("green");
          }
          else
          {
            space.SetNormal("yellow");
          }
        }
        else
        {
          space.SetNormal("red");
        }


        if ((_draygon && _screwAttack && _canFly)
            || (_draygon && _screwAttack && _hjboots)
            || (_draygon && _plasmaBeam && _canFly)
            || (_draygon && _plasmaBeam && _hjboots))
        {
          plamsa.SetNormal("green");
        }
        else
        {
          plamsa.SetNormal("red");
        }
      }
      else
      {
        space.SetNormal("red");
        draymissle.SetNormal("red");
        waterhole.SetNormal("red");
        beach.SetNormal("red");
        sandpitleft.SetNormal("red");
        sandpitRight1.SetNormal("red");
        sandpitRight2.SetNormal("red");
        aquaDuct1.SetNormal("red");
        aquaDuct2.SetNormal("red");
        botwoonE.SetNormal("red");
        plamsa.SetNormal("red");

      }

      /*
                       "[hard],@CanReachAqueduct,super,hijump",
                       "[hard],@CanReachAqueduct,super,gravity"
                       "[hard],@CanReachAqueduct,super,hijump,@CanSpringBallJump",
                       "[hard],@CanReachAqueduct,super,gravity"
                           "[hard],draygon,speed",
                           "[hard],draygon,screw,@CanSpringBallJump",
                           "[hard],draygon,plasma,@CanSpringBallJump",
                           "[hard],draygon,charge,alltanks:3,hijump",
                           "[hard],draygon,charge,alltanks:3,@CanSpringBallJump",
                           "[hard],draygon,charge,alltanks:3,@CanFly"
                   */


      // Norfair Checks 

      _canAccessNorfairUpperWest = (_canAccessNorfairUpperPortal)
                                   || (_speedBoost && _super && _morphball)
                                   || (_canDestroyBombWalls && _super && _morphball);


      if (_canAccessNorfairUpperWest)
      {
        crocEscape.SetNormal("blue");
        hjBe.SetNormal("green");
        if (_canPassBombPassages)
        {
          hjb.SetNormal("green");
          hjBmissles.SetNormal("green");
          if (_canUsePowerBombs)
          {
            crumbleShaft.SetNormal("yellow");
          }
        }
        else
        {
          hjb.SetNormal("red");
          hjBmissles.SetNormal("red");
        }

        if (_morphball)
        {
          ice.SetNormal("yellow");
          hjBmissles.SetNormal("yellow");
        }
        else if (_canPassBombPassages && _varia && _speedBoost)
        {
          ice.SetNormal("green");
          if (_canUsePowerBombs)
          {
            crumbleShaft.SetNormal("green");
          }
          else
          {
            crumbleShaft.SetNormal("red");
          }
        }
        else
        {
          ice.SetNormal("red");
          hjBmissles.SetNormal("red");
        }
      }

      else
      {
        ice.SetNormal("red");
        crumbleShaft.SetNormal("red");
        hjBmissles.SetNormal("red");
        hjBe.SetNormal("red");
        hjb.SetNormal("red");
        crocEscape.SetNormal("red");
      }
/*
              "[hard],missile,varia,speed,@CanAccessCrocomire,@CardNorfairL1",
              "[hard],super,varia,speed,@CanAccessCrocomire,@CardNorfairL1",
              "[hard],wave,varia,speed,@CanAccessCrocomire,@CardNorfairL1"
       */



// NorfairUpperEast

      _canAccessNorfairUpperEast =
        (_canAccessNorfairUpperWest && _varia && _super && _canOpenCathedralDoor && _spaceJump)
        || (_canAccessNorfairUpperWest && _varia && _super && _canOpenCathedralDoor && _canIbj)
        || (_canAccessNorfairUpperWest && _varia && _super && _canOpenCathedralDoor &&
            _hjboots)
        || (_canAccessNorfairUpperWest && _varia && _super && _canOpenCathedralDoor &&
            _speedBoost)
        || (_canAccessNorfairUpperWest && _varia && _super && _canIbj)
        || (_canAccessNorfairUpperWest && _varia && _super && _speedBoost && _waveBeamItem &&
            _canUsePowerBombs);
/*
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,@CanFly",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,hijump",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,speed",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,@CanSpringBallJump",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,varia,ice",
          "[hard],@Norfair Upper West,@CanHellRun,speed,@CardNorfairL2,@CanUsePowerBombs",
          "[hard],@Norfair Upper West,@CanHellRun,speed,@CanBlueGateGlitch,@CanUsePowerBombs",
        ],*/

      if (_canAccessNorfairUpperEast)
      {
        waveBeamMissle.SetNormal("yellow");
        waveBeam.SetNormal("yellow");
        bubbleLeft.SetNormal("yellow");
        speed.SetNormal("yellow");
        speedMissle.SetNormal("yellow");
        bubblemountains.SetNormal("green");

        if (_morphball)
        {
          uNresreve.SetNormal("yellow");
          waveBeam.SetNormal("green");
          waveBeamMissle.SetNormal("green");
          lavaRoom.SetNormal("green");
        }
        else
        {
          uNresreve.SetNormal("red");
          lavaRoom.SetNormal("blue");
        }

        if (_canIbj || _spaceJump
                    || _grapple
                    || (_hjboots && _speedBoost))
        {
          crocEscape.SetNormal("yellow");
          if (waveBeam)
          {
            crocEscape.SetNormal("green");
          }
        }
        else
        {
          crocEscape.SetNormal("red");
        }

        if (_canIbj || _spaceJump
                    || _grapple
                    || _hjboots
                    || _iceBeam)
        {
          bubbleLeft.SetNormal("green");

          if (_morphball)
          {
            uNresreve.SetNormal("green");
          }
          else
          {
            uNresreve.SetNormal("red");
          }
        }
      }
      else
      {
        speedMissle.SetNormal("red");
        speed.SetNormal("red");
        bubbleLeft.SetNormal("red");
        waveBeam.SetNormal("red");
        waveBeamMissle.SetNormal("red");
        bubbleLeft.SetNormal("red");
        bubblemountains.SetNormal("red");
        uNresreve.SetNormal("red");
        crocEscape.SetNormal("red");
        lavaRoom.SetNormal("red");
      }


      _canAccessCrocomire = (_canAccessNorfairUpperWest && _varia && _canUsePowerBombs && _speedBoost && _super)
                            || (_canAccessNorfairUpperWest && _varia && _speedBoost && _waveBeamItem)
                            || (_canAccessNorfairUpperWest && _varia && _super && (_canIbj || _spaceJump || _hjboots) &&
                                (_canBlueGateGlitch || _waveBeamItem));
/*

          "[hard],@Norfair Upper West,@CanOpenIceBeamDoor,@CanUsePowerBombs,speed,alltanks:3",
          "[hard],@Norfair Upper West,@CanOpenIceBeamDoor,@CanUsePowerBombs,speed,varia",
          "[hard],@Norfair Upper West,speed,alltanks:2,@CanBlueGateGlitch",
          "[hard],@Norfair Upper West,speed,varia,@CanBlueGateGlitch",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,@CanFly,@CanPassBombPassages,@CanBlueGateGlitch",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,@CanFly,varia,morph,@CanBlueGateGlitch",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,hijump,@CanPassBombPassages,@CanBlueGateGlitch",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,hijump,varia,morph,@CanBlueGateGlitch",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,speed,@CanPassBombPassages,@CanBlueGateGlitch",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,speed,varia,morph,@CanBlueGateGlitch",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,@CanSpringBallJump,@CanPassBombPassages,@CanBlueGateGlitch",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,@CanSpringBallJump,varia,morph,@CanBlueGateGlitch",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,varia,ice,@CanPassBombPassages,@CanBlueGateGlitch",
          "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanOpenCathedralDoor,varia,ice,morph,@CanBlueGateGlitch",

          "[hard],@CanAccessNorfairLowerPortal,screw,space,varia,super,alltanks:2,@CardNorfairL2",
          "[hard],@CanAccessNorfairLowerPortal,screw,space,varia,super,alltanks:2,morph"
         */ /*
                    // This item can be accessed via UN west or east so it's easier to put it here to reference those areas.
                    // Put morph requirement inside section so we can make it able to be scouted.
                    "name": "Missile (lava room)",

                      "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanFly",
                      "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,hijump",
                      "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,speed",
                      "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,@CanSpringBallJump",
                      "[hard],@Norfair Upper West,@CanHellRun,@CanOpenRedDoors,varia,ice",
                      "[hard],@Norfair Upper East,varia,@CardNorfairL2"
                  */

      if (_canAccessCrocomire)
      {

        crocE.SetNormal("green");
        if (_tank1)
        {
          crocEtank.SetNormal("green");
        }
        else
        {
          crocEtank.SetNormal("yellow");
        }

        if (_spaceJump || _grapple || _canIbj)
        {
          crocEtank.SetNormal("green");
          crocPBs.SetNormal("green");
          indy.SetNormal("green");
          grapple.SetNormal("green");
        }
        else
        {
          grapple.SetNormal("yellow");
          crocPBs.SetNormal("yellow");
          crocEtank.SetNormal("yellow");
          indy.SetNormal("red");
        }
      }
      else
      {
        grapple.SetNormal("red");
        crocE.SetNormal("red");
        indy.SetNormal("red");
        crocEtank.SetNormal("red");
        crocPBs.SetNormal("red");
      }

      _cannorfairLowerWest = (_varia && _canAccessNorfairUpperEast && _canUsePowerBombs && _gravity && _spaceJump)
                             || (_canAccessNorfairLowerPortal && _canDestroyBombWalls)
                             || (_varia && _canAccessNorfairUpperEast && _canUsePowerBombs && _hjboots && _tank2)
                             || (_varia && _canAccessNorfairUpperEast && _canUsePowerBombs && _gravity);

      if (_cannorfairLowerWest)
      {

        if (_canAccessNorfairLowerPortal && _varia || _gravity && _varia && _spaceJump)
        {
          screw.SetNormal("green");
          gTblock.SetNormal("green");
          if (_spaceJump)
          {
            spaceGt.SetNormal("green");
          }
          else
          {
            spaceGt.SetNormal("blue");
          }

        }
        else if (_varia && _hjboots || _gravity && _varia)
        {
          gTblock.SetNormal("orange");
          screw.SetNormal("orange");
          if (_spaceJump)
          {
            spaceGt.SetNormal("orange");
          }
          else
          {
            spaceGt.SetNormal("blue");
          }

        }
        else
        {
          screw.SetNormal("yellow");
          gTblock.SetNormal("yellow");
          spaceGt.SetNormal("blue");
        }

        if (_varia && (_spaceJump || _canIbj || _hjboots || _canSpringBallJump))
        {
          mickeymouse.SetNormal("yellow");
          jailmissle.SetNormal("yellow");
          jail.SetNormal("blue");
          firefeas.SetNormal("yellow");

          if (!_canAccessNorfairLowerPortal && !_gravity && _canIbj)
          {
            mickeymouse.SetNormal("yellow");
            jailmissle.SetNormal("yellow");
            jail.SetNormal("blue");
            firefeas.SetNormal("yellow");
            pbShame.SetNormal("yellow");
            jail.SetNormal("yellow");
            ridleyE.SetNormal("yellow");
          }

          if (_canUsePowerBombs)
          {
            pbShame.SetNormal("yellow");
            jail.SetNormal("yellow");
            ridleyE.SetNormal("yellow");
          }

          if (_canPassBombPassages)
          {
            musket.SetNormal("yellow");
            jail.SetNormal("yellow");
          }

          if (_spaceJump)
          {
            mickeymouse.SetNormal("green");
            jailmissle.SetNormal("green");
            if (_canPassBombPassages)
            {
              musket.SetNormal("green");
              jail.SetNormal("green");
            }

            if (_canUsePowerBombs)
            {
              jailmissle.SetNormal("green");
              firefeas.SetNormal("green");
              pbShame.SetNormal("green");
              jail.SetNormal("green");
              musket.SetNormal("green");
              ridleyE.SetNormal("green");
            }
          }
          else
          {
            mickeymouse.SetNormal("yellow");
            jailmissle.SetNormal("yellow");
            jail.SetNormal("blue");
            firefeas.SetNormal("yellow");
            pbShame.SetNormal("yellow");
            jail.SetNormal("yellow");
            ridleyE.SetNormal("yellow");
          }


        }
        else
        {
          jailmissle.SetNormal("red");
          firefeas.SetNormal("red");
          pbShame.SetNormal("red");
          jail.SetNormal("red");
          musket.SetNormal("red");
          ridleyE.SetNormal("red");
          mickeymouse.SetNormal("red");
        }
      }
      else
      {
        screw.SetNormal("red");
        gTblock.SetNormal("red");
        spaceGt.SetNormal("red");
        jailmissle.SetNormal("red");
        firefeas.SetNormal("red");
        pbShame.SetNormal("red");
        jail.SetNormal("red");
        musket.SetNormal("red");
        ridleyE.SetNormal("red");
        mickeymouse.SetNormal("red");
      }


// alttplogic
      // light world

      if (_pendentcount == 2 && _greenpendent)
      {
        pedastil.SetNormal("green");
      }
      else if (_book)
      {
        pedastil.SetNormal("blue");
      }
      else
      {
        pedastil.SetNormal("red");
      }

      bar.SetNormal("green");
      checkenhut.SetNormal("green");
      bottlevender.SetNormal("green");
      woods.SetNormal("green");
      woods2.SetNormal("green");
      well.SetNormal("green");
      uncle.SetNormal("green");
      lumberjack.SetNormal("blue");
      backofgreenpendent.SetNormal("green");
      house.SetNormal("green");
      lightsp.SetNormal("green");
      southsore.SetNormal("green");
      desertcave.SetNormal("green");
      desertlegde.SetNormal("blue");
      icerod.SetNormal("green");
      bookshelf.SetNormal("blue");
      race.SetNormal("green");
      blindsden.SetNormal("green");

      if (_boots)
      {
        bumbrock.SetNormal("green");
        bookshelf.SetNormal("green");
        if (_aga1)
        {
          lumberjack.SetNormal("green");
        }
      }
      else
      {
        bumbrock.SetNormal("red");
      }

      if (_bottle)
      {
        bottlekid.SetNormal("green");
      }
      else
      {
        bottlekid.SetNormal("red");
      }

      //magic bat
      if ((_glove2 && _pearl && _mirror) || _hammer)
      {
        if (_powder)
        {
          magicbat.SetNormal("green");
        }

        else if (_mushroom)
        {
          magicbat.SetNormal("yellow");
        }
      }

      else
      {
        magicbat.SetNormal("red");
      }

      if (_greenpendent)
      {
        greenpendent.SetNormal("green");
      }
      else
      {
        greenpendent.SetNormal("red");
      }

      if (_flip || _glove1)
      {
          scam.SetNormal("green");
        
          
      }
      else
      {
        scam.SetNormal("orange");
      }

      if (_flip)
      {
        waterfall.SetNormal("green");
        hobo.SetNormal("green");
      }
      else if (_pearl)
      {
        waterfall.SetNormal("yellow");
      }
      else
      {
        waterfall.SetNormal("red");
        hobo.SetNormal("yellow");
      }

      if (_mushroom)
      {
        mushroom.SetNormal("green");
      }
      else
      {
        mushroom.SetNormal("red");
      }

      if ((_mirror && _flute && _glove2) || (_mirror && _canAccessMiseryMirePortal && _glove1))
      {
        darkdesertrock2.SetNormal("green");
      }
      else
      {
        darkdesertrock2.SetNormal("red");
      }

      if (_book || (_mirror && _glove2 && _flute) || (_canAccessMiseryMirePortal && _mirror))
      {
        desertlegde.SetNormal("green");
        dp.SetNormal("orange");
        if (_sword1 || _hammer || _bowz3 || _firerod || _icerod || _bluecane || _redcane)
        {
          if (_boots)
          {
            dp.SetNormal("green");
          }
          else
          {
            dp.SetNormal("yellow");
          }
        }
      }
      else
      {
        dp.SetNormal("red");
      }

      if (_shovel)
      {
        shovel.SetNormal("green");
      }
      else
      {
        shovel.SetNormal("red");
      }

      if (_glove1)
      {
       
      }

      if (_canAccessDeathMountainPortal || _flute || (_glove1 && _lamp))
      {
        oldman.SetNormal("yellow");
        lightleftside.SetNormal("green");

       
        if (_book)
        {
          if (_sword2)
          {
            tabletmountain.SetNormal("green");
          }
          else
          {
            tabletmountain.SetNormal("blue");
          }
        }
       

        if (_mirror)
        {
          mirrorleftside.SetNormal("green");
        }
        else
        {
          mirrorleftside.SetNormal("blue");
        }

        if (_mirror && _hammer || _hook)
        {
          lightmountain.SetNormal("green");
          spiralcave.SetNormal("green");
          mountainrightbot.SetNormal("green");
          mountainisland.SetNormal("blue");
        }
        else
        {
          lightmountain.SetNormal("red");
          spiralcave.SetNormal("red");
          mountainisland.SetNormal("red");
          mountainrightbot.SetNormal("red");
        }

        if (_lamp)
        {
          oldman.SetNormal("green");
        }

      }
      else if (_glove1)
      {
        oldman.SetNormal("yellow");
        lightleftside.SetNormal("yellow");
      }
      else
      {
        lightmountain.SetNormal("red");
        spiralcave.SetNormal("red");
        mountainisland.SetNormal("red");
        mountainrightbot.SetNormal("red");
        oldman.SetNormal("red");
        mirrorleftside.SetNormal("red");
        tabletmountain.SetNormal("red");
        lightleftside.SetNormal("red");
      }

      _darkworldaccess = (_aga1 || (_pearl && _hammer && _glove1) || (_pearl && _glove2 && _flip) ||
                          (_pearl && _canAccessDarkWorldPortal && _flip));

      if (_darkworldaccess)
      {
        pymidledge.SetNormal("green");
        if (_pearl && _glove1)
        {
          catfish.SetNormal("green");
        }
        else
        {
          catfish.SetNormal("red");
        }
      }
      else
      {
        pymidledge.SetNormal("red");
        catfish.SetNormal("red");
      }

      _darkworldNorthwestaccess = (_pearl && _hook && _aga1 && _flip)
                                  || (_pearl && _hook && _aga1 && _hammer)
                                  || (_pearl && _hook && _aga1 && _glove1)
                                  || (_pearl && _hook && _canAccessDarkWorldPortal && _flip)
                                  || (_pearl && _hammer && _glove1)
                                  || (_pearl && _glove2);
      if (_darkworldNorthwestaccess)
      {
        ttshed.SetNormal("green");
        mario.SetNormal("green");
        chestgame.SetNormal("green");

        if (_hammer && _glove2)
        {
          hammerpegs.SetNormal("green");
        }
        else
        {
          hammerpegs.SetNormal("red");
        }

        if (_cape && _glove1)
        {
          bumberledge.SetNormal("green");
        }
        else
        {
          bumberledge.SetNormal("red");
        }

        if (_mirror)
        {
          graveyardledge.SetNormal("green");
        }
        else
        {
          graveyardledge.SetNormal("red");
        }

        if (_glove2)
        {
          smithy.SetNormal("green");
          smithchain.SetNormal("green");
        }
        else
        {
          smithchain.SetNormal("red");
          smithy.SetNormal("red");
        }

      }
      else
      {
        ttshed.SetNormal("red");
        chestgame.SetNormal("red");
        mario.SetNormal("red");
        smithy.SetNormal("red");
        smithchain.SetNormal("red");
        graveyardledge.SetNormal("red");
        bumberledge.SetNormal("red");
        hammerpegs.SetNormal("red");
      }

      _canAcessDarkWorldSouth = (_pearl && _aga1 && _hammer)
                                || (_pearl && _aga1 && _hook && _flip)
                                || (_pearl && _aga1 && _hook && _glove1)
                                || (_pearl && _canAccessDarkWorldPortal && _flip && _hammer)
                                || (_pearl && _canAccessDarkWorldPortal && _flip && _hook)
                                || (_pearl && _hammer && _glove1)
                                || (_pearl && _glove2);

      if (_canAcessDarkWorldSouth)
      {
        hypecave.SetNormal("green");
        hypescave.SetNormal("green");
        diggame.SetNormal("green");
        stumpy.SetNormal("green");

        if (_book && _mirror)
        {
         
          if (_sword2)
          {
            deserttablet.SetNormal("green");
          }
          else
          {
             deserttablet.SetNormal("yellow");
          }

        }
        else
        {
          deserttablet.SetNormal("red");
        }

        if (_mirror)
        {
          cave45.SetNormal("green");

        }
        else
        {
          cave45.SetNormal("red");
        }

        if ((_redcrystals.itemcount == 2 && _hammer) || (_redcrystals.itemcount == 2 && _mirror && _aga1))
        {
          pymidfairy.SetNormal("green");
        }
        else
        {
          pymidfairy.SetNormal("red");
        }
      }
      else
      {
        pymidfairy.SetNormal("red");
        cave45.SetNormal("red");
        stumpy.SetNormal("red");
        diggame.SetNormal("red");
        deserttablet.SetNormal("red");
        hypescave.SetNormal("red");
        hypecave.SetNormal("red");
      }

      _canAccessDarkWorldMire = (_flute && _glove2) || (_canAccessMiseryMirePortal);

      if (_canAccessDarkWorldMire)
      {
        if (_pearl)
        {
          darkdesertrock2.SetNormal("green");
        }
        else
        {
          darkdesertrock2.SetNormal("red");
        }

        if (_pearl && _mirror && _glove1)
        {
          darkdesertrock.SetNormal("green");
        }
        else
        {
          darkdesertrock.SetNormal("red");
        }
      }
      else
      {
        darkdesertrock.SetNormal("red");
        darkdesertrock2.SetNormal("red");
      }

      _canAccessLightworldMountain = _canAccessDeathMountainPortal || _flute || (_glove1 && _lamp);
      if (_canAccessLightworldMountain)
      {
        if (_pearl && _hammer && _glove1 && (_cape || _bluecane))
        {
          hypescave.SetNormal("green");
        }
        else
        {
          hypescave.SetNormal("red");
        }
      }
      else
      {
        hypescave.SetNormal("red");
      }

      _canAccessDarkWorldMountainEast = _canAccessLightworldMountain && _glove2;

      if (_canAccessDarkWorldMountainEast)
      {
        darkmountian.SetNormal("green");
        if (_boots && _pearl)
        {
          darkmountain2.SetNormal("orange");
        }

        if (_pearl && _hook)
        {
          darkmountain2.SetNormal("green");
        }

      }
      else
      {
        darkmountian.SetNormal("red");
        darkmountain2.SetNormal("red");
      }

      escape.SetNormal("green");


      if (_lamp && _bowz3)
      {
        eastern.SetNormal("green");
      }
      else
      {
        eastern.SetNormal("orange");
      }

      if ((_canAccessLightworldMountain && _mirror) || (_canAccessLightworldMountain && _hook && _hammer))
      {

        if (_lamp && (_sword1 || _hammer || _bowz3 || _firerod || _icerod || _bluecane || _redcane))
        {
          toh.SetNormal("green");
        }
        else
        {
          toh.SetNormal("yellow");
        }
      }
      else
      {
        toh.SetNormal("red");
      }

      if (_cape && _lamp || (_lamp && _sword2))
      {
        aga1check.SetNormal("green");

      }
      else
      {
        aga1check.SetNormal("red");
      }

      if (_darkworldaccess && _pearl)
      {

        if (_bowz3 && _lamp && _hammer)
        {
          pod.SetNormal("green");
        }
        else
        {
          pod.SetNormal("yellow");
        }
      }
      else
      {
        pod.SetNormal("red");
      }

      if (_canAcessDarkWorldSouth && _pearl && _mirror && _flip)
      {

        if (_hammer && _hook)
        {
          swamp.SetNormal("green");
        }
        else
        {
          swamp.SetNormal("yellow");
        }
      }
      else
      {
        swamp.SetNormal("red");
      }

      if (_pearl && _darkworldNorthwestaccess)
      {


        if (_hammer && (_sword1 || _redcane
                                || _bluecane))
        {
          tt.SetNormal("green");
        }
        else
        {
          tt.SetNormal("yellow");
        }


        if (_firerod && (_sword1|| _sword2))
        {
          skull.SetNormal("green");

        }
        else
        {
          skull.SetNormal("yellow");
        }
      }

      else
      {
        skull.SetNormal("red");
        tt.SetNormal("red");
      }

      if (_pearl && _glove2 && (_firerod || _bombos))
      {

        if (_hook && _hammer && _flip)
        {
          icepal.SetNormal("green");
        }
        else
        {
          icepal.SetNormal("yellow");
        }
      }
      else
      {
        icepal.SetNormal("red");
      }
      

      if (_mmaccess && (_sword1|| _sword2) && _pearl && (_boots || _hook))
      {

        if (_redcane && _lamp)
        {
          mm.SetNormal("green");
        }
        else
        {
          mm.SetNormal("yellow");
        }
      }
      else
      {
        mm.SetNormal("red");
      }

      if (_traccess && _canAccessDarkWorldMountainEast && (_sword1|| _sword2) && _pearl && _glove2 && _hammer && _redcane)
      {
        if (_firerod && _lamp && _mirror)
        {
          mimic.SetNormal("green");
        }
        else
        {
          mimic.SetNormal("yellow");
        }

        if (_firerod && _icerod && _lamp)
        {
          tr.SetNormal("green");

        }
        else
        {
          tr.SetNormal("yellow");
        }
      }
      else
      {
        tr.SetNormal("red");
        mimic.SetNormal("red");
      }

      if (_crystalcount.itemcount >= _requriedcount)
      {
        if (_firerod && _hammer && _hook && _bowz3)
        {
          gt.SetNormal("green");
        }
        else
        {
          gt.SetNormal("yellow");
        }
      }
      else
      {
        gt.SetNormal("red");
      }

      if ((_boots && _glove2) || (_boots && _mirror && _darkworldaccess))
      {
        kingstomb.SetNormal("green");
      }
      else
      {
        kingstomb.SetNormal("red");
      }

      if (_flip && _mirror && _pearl && (_canAcessDarkWorldSouth || _darkworldaccess))
      {
        island.SetNormal("green");
      }
      else
      {
        island.SetNormal("blue");
      }

      //M1 Logic
      m1morph.SetNormal("green");
      m1firste.SetNormal("green");
      m1firstmissle.SetNormal("green");
      m1norfairleft1.SetNormal("green");


      if (_m1missle)
      {
        m1longbeam.SetNormal("green");
        m1bombs.SetNormal("green");
        m1icebeam.SetNormal("yellow");
      }
      else
      {
        m1longbeam.SetNormal("red");
        m1bombs.SetNormal("red");
        m1icebeam.SetNormal("red");
      }

      if (_m1Bombs && _m1Morph)
      {

        m1ridleybehind.SetNormal("green");
        m1ridleybot.SetNormal("green");
        m1ridleyshowitem.SetNormal("blue");
        m1norfairmidbombs.SetNormal("green");
        m1norfairmidbombs2.SetNormal("green");
      }
      else
      {

        m1ridleybehind.SetNormal("red");
        m1ridleybot.SetNormal("red");
        m1norfairmidbombs.SetNormal("red");
        m1norfairmidbombs2.SetNormal("red");
      }

      if (_m1Morph && _m1Hbj && _m1missle && (_m1Bombs || _m1WaveBeam))
      {
        m1varia.SetNormal("green");
      }
      else
      {
        m1varia.SetNormal("red");
      }

      if (_m1Morph && _m1Hbj && _m1Bombs)
      {
        m1ridleyleft1.SetNormal("green");
      }
      else if (_m1Morph && _m1Bombs)
      {
        m1ridleyleft1.SetNormal("orange");
      }
      else
      {
        m1ridleyleft1.SetNormal("red");
      }

      if (_m1Morph && _m1missle && (_m1Bombs || _m1WaveBeam))
      {
        m1topmissles.SetNormal("green");
        if (_m1Bombs)
        {
          m1ridleyleft2.SetNormal("green");
          m1topmissles2.SetNormal("green");
          m1norfairleft2.SetNormal("green");
        }
        else
        {
          m1topmissles2.SetNormal("red");
          m1norfairleft2.SetNormal("red");
          m1ridleyleft2.SetNormal("red");
        }
      }
      else
      {
        m1topmissles.SetNormal("red");
        m1topmissles2.SetNormal("red");
        m1norfairleft2.SetNormal("red");
        m1ridleyleft2.SetNormal("red");
      }

      if (_m1Morph)
      {

        m1ridleybot.SetNormal("yellow");
      }
      else
      {

        m1ridleybot.SetNormal("red");
      }

      if (_m1Morph && _m1Bombs && _m1missle)
      {
        m1icebeam.SetNormal("green");
        m1ridleybot.SetNormal("green");
        m1kraidright1.SetNormal("green");
        m1kraidright2.SetNormal("green");
        m1kraidright3.SetNormal("green");
        m1kraide.SetNormal("green");
        m1kraidleft1.SetNormal("green");
        m1kraidleft2.SetNormal("green");
        m1ridleyshowitem.SetNormal("green");
      }

      else if (_m1Morph && _m1missle)
      {
        m1kraidright1.SetNormal("yellow");
        m1kraidright3.SetNormal("yellow");
        m1kraide.SetNormal("yellow");
        m1kraidleft1.SetNormal("yellow");
        m1kraidleft2.SetNormal("yellow");
        m1kraidright2.SetNormal("red");
        m1ridleyshowitem.SetNormal("red");
        m1ridleybot.SetNormal("yellow");
      }


      else
      {
        m1kraidright1.SetNormal("red");
        m1kraidright2.SetNormal("red");
        m1kraidright3.SetNormal("red");
        m1kraide.SetNormal("red");
        m1kraidleft1.SetNormal("red");
        m1kraidleft2.SetNormal("red");
        m1ridleyleft2.SetNormal("red");
        m1ridleyshowitem.SetNormal("red");
        m1norfairleft2.SetNormal("red");
      }


      if (_m1IceBeam)
      {
        m1ceiling.SetNormal("green");
      }
      else
      {
        m1ceiling.SetNormal("blue");
      }

      if (_m1IceBeam || _m1Hbj)
      {
        m1norfairmidmissles.SetNormal("green");
        m1norfairmidmissles2.SetNormal("green");
        m1norfairmidmissles3.SetNormal("green");
      }
      else
      {
        m1norfairmidmissles.SetNormal("red");
        m1norfairmidmissles2.SetNormal("red");
        m1norfairmidmissles3.SetNormal("red");
      }

      if (_m1IceBeam && _m1Bombs && _m1Morph && _m1missle)
      {
        m1norfairtopmissles2.SetNormal("green");
        m1norfairtopmissles.SetNormal("green");
        m1norfairbotmissles.SetNormal("green");
      }
      else
      {

        m1norfairtopmissles2.SetNormal("red");
        m1norfairtopmissles.SetNormal("red");
        m1norfairbotmissles.SetNormal("red");

      }

      if (_m1IceBeam && _m1Bombs && _m1Morph && _m1missle)
      {
        m1norfairstartofhell.SetNormal("green");
        m1norfairstartofhell3.SetNormal("green");
        m1norfairstartofhell4.SetNormal("green");
        m1norfairstartofhell5.SetNormal("green");
        m1norfairstartofhell6.SetNormal("green");
        m1norfairstartofhell7.SetNormal("green");
        m1norfairstartofhell2.SetNormal("green");
      }
      else if (_m1Bombs && _m1Morph && _m1missle)
      {
        m1norfairstartofhell.SetNormal("orange");
        m1norfairstartofhell3.SetNormal("orange");
        m1norfairstartofhell4.SetNormal("orange");
        m1norfairstartofhell5.SetNormal("orange");
        m1norfairstartofhell6.SetNormal("orange");
        m1norfairstartofhell7.SetNormal("orange");
        m1norfairstartofhell2.SetNormal("orange");
      }
      else
      {
        m1norfairstartofhell.SetNormal("red");
        m1norfairstartofhell3.SetNormal("red");
        m1norfairstartofhell4.SetNormal("red");
        m1norfairstartofhell5.SetNormal("red");
        m1norfairstartofhell6.SetNormal("red");
        m1norfairstartofhell7.SetNormal("red");
        m1norfairstartofhell2.SetNormal("red");
      }

      // z1 overworld logic 

      oldman1.SetNormal("green");


      undersolder.SetNormal("green");
      notecheck.SetNormal("green");
      bombtakeany1.SetNormal("yellow");
      bombtakeany2.SetNormal("yellow");
      if (_z1Candle || (_z1Book && _z1Wand))
      {
        bushtakeany.SetNormal("green");
      }
      else
      {
        bushtakeany.SetNormal("red");
      }

      if (_z1Ladder)
      {
        floatingboard.SetNormal("green");
        floatingboard2.SetNormal("green");
        
      }
      else
      {
        floatingboard.SetNormal("blue");
        floatingboard2.SetNormal("blue");
      }

      if (_z1bombs)
      {
        bombtakeany1.SetNormal("green");
        bombtakeany2.SetNormal("green");
      }
      else
      {
        bombtakeany1.SetNormal("yellow");
        bombtakeany2.SetNormal("yellow");
      }

      if (_z1Raft)
      {
        rafttakeitem.SetNormal("green");
      }
      else
      {
        rafttakeitem.SetNormal("red");
      }

      if (_heart6)
      {
        oldman2.SetNormal("green");
      }
      else
      {
        oldman2.SetNormal("blue");
      }

      if (_heart12)
      {
        oldmangrave.SetNormal("green");
      }
      else
      {
        oldmangrave.SetNormal("blue");
      }

      // dungeon checks
      //D1
      if (_z1Candle || _z1Wood || _z1Wand || (_z1Bow && _z1Airrows))
      {
        d1a.SetNormal("green");
        d1b.SetNormal("green");
        d1c.SetNormal("green");
        d1d.SetNormal("green");
        d1e.SetNormal("green");
        d1f.SetNormal("green");
        d1h.SetNormal("green");
        d1g.SetNormal("green");
        d1i.SetNormal("green");
        d1q.SetNormal("green");
        d1Boss.SetNormal("green");
        d2a.SetNormal("green");
        d2b.SetNormal("green");
        d2c.SetNormal("green");
        d2d.SetNormal("green");
        d2e.SetNormal("green");
        d2f.SetNormal("green");
        d2g.SetNormal("green");
        d2h.SetNormal("green");
        d2i.SetNormal("green");
        d2q.SetNormal("green");
        d2Boss.SetNormal("green");
        d3a.SetNormal("green");
        d3b.SetNormal("green");
        d3c.SetNormal("green");
        d3d.SetNormal("green");
        d3e.SetNormal("green");
        d3f.SetNormal("green");
        d3g.SetNormal("green");
        d3h.SetNormal("green");
        d3i.SetNormal("green");
        d3q.SetNormal("green");
        d3x.SetNormal("green");
        d3t.SetNormal("green");
        d3Boss.SetNormal("green");
      }
      else if (_z1bombs)
      {
        d1a.SetNormal("green");
        d1b.SetNormal("green");
        d1c.SetNormal("yellow");
        d1d.SetNormal("yellow");
        d1e.SetNormal("yellow");
        d1f.SetNormal("green");
        d1h.SetNormal("yellow");
        d1g.SetNormal("green");
        d1i.SetNormal("green");
        d1q.SetNormal("green");
        d1Boss.SetNormal("yellow");
        d2a.SetNormal("yellow");
        d2b.SetNormal("yellow");
        d2c.SetNormal("green");
        d2d.SetNormal("green");
        d2e.SetNormal("yellow");
        d2f.SetNormal("yellow");
        d2g.SetNormal("green");
        d2h.SetNormal("yellow");
        d2i.SetNormal("yellow");
        d2q.SetNormal("yellow");
        d2Boss.SetNormal("green");
        d3a.SetNormal("green");
        d3b.SetNormal("yellow");
        d3c.SetNormal("yellow");
        d3d.SetNormal("yellow");
        d3e.SetNormal("green");
        d3f.SetNormal("yellow");
        d3g.SetNormal("yellow");
        d3h.SetNormal("green");
        d3i.SetNormal("green");
        d3q.SetNormal("yellow");
        d3x.SetNormal("yellow");
        d3t.SetNormal("yellow");
        d3Boss.SetNormal("yellow");

      }
      else
      {
        d1a.SetNormal("red");
        d1b.SetNormal("red");
        d1c.SetNormal("red");
        d1d.SetNormal("red");
        d1e.SetNormal("red");
        d1f.SetNormal("red");
        d1h.SetNormal("red");
        d1g.SetNormal("red");
        d1i.SetNormal("red");
        d1q.SetNormal("red");
        d1Boss.SetNormal("red");
        d2a.SetNormal("red");
        d2b.SetNormal("red");
        d2c.SetNormal("red");
        d2d.SetNormal("red");
        d2e.SetNormal("red");
        d2f.SetNormal("red");
        d2g.SetNormal("red");
        d2h.SetNormal("red");
        d2i.SetNormal("red");
        d2q.SetNormal("red");
        d2Boss.SetNormal("red");
        d3a.SetNormal("red");
        d3b.SetNormal("red");
        d3c.SetNormal("red");
        d3d.SetNormal("red");
        d3e.SetNormal("red");
        d3f.SetNormal("red");
        d3g.SetNormal("red");
        d3h.SetNormal("red");
        d3i.SetNormal("red");
        d3q.SetNormal("red");
        d3x.SetNormal("red");
        d3t.SetNormal("red");
        d3Boss.SetNormal("red");

      }

      if (_z1Raft && (_z1Candle || _z1Wood || _z1Wand || (_z1Bow && _z1Airrows)))
      {
        d4a.SetNormal("green");
        d4b.SetNormal("green");
        d4c.SetNormal("green");
        d4d.SetNormal("green");
        d4e.SetNormal("green");
        if (_z1Ladder)
        {
          d4f.SetNormal("green");
          d4h.SetNormal("green");
          if (_z1Wood || _z1Wand)
          {
            d4Boss.SetNormal("green");
          }
          else
          {
            d4Boss.SetNormal("red");
          }
        }
        else
        {
          d4f.SetNormal("red");
          d4h.SetNormal("red");
          d4Boss.SetNormal("red");
        }
      }
      else if (_z1Raft && _z1bombs)
      {
        d4a.SetNormal("green");
        d4b.SetNormal("yellow");
        d4c.SetNormal("yellow");
        d4d.SetNormal("green");
        d4e.SetNormal("green");
        if (_z1Ladder)
        {
          d4f.SetNormal("green");
          d4h.SetNormal("green");
        }
        else
        {
          d4f.SetNormal("red");
          d4h.SetNormal("red");
        }

        d4Boss.SetNormal("red");
      }

      else
      {
        d4a.SetNormal("red");
        d4b.SetNormal("red");
        d4c.SetNormal("red");
        d4d.SetNormal("red");
        d4e.SetNormal("red");
        d4f.SetNormal("red");
        d4h.SetNormal("red");
        d4Boss.SetNormal("red");
      }

      _canKillMostZ1Things = _z1bombs || _z1Candle || _z1Wood || _z1Wand || (_z1Bow && _z1Airrows);
      _canKillBosses = _z1bombs || _z1Wood || _z1Wand || (_z1Bow && _z1Airrows);
      _canKillDarknuts = _z1bombs || _z1Wood || _z1Wand;
      _canKillGleeok = _z1Wood || _z1Wand;
      _canKillPolsVoice = _z1bombs || _z1Wood || (_z1Bow && _z1Airrows);
      _canKillWizzrobes = _z1bombs || _z1Wood;

      if (_canKillMostZ1Things)
      {
        d5a.SetNormal("green");
        d5h.SetNormal("green");
        d5i.SetNormal("green");
        d5q.SetNormal("green");
        d5x.SetNormal("green");

        if (_z1Ladder)
        {
          d5z.SetNormal("green");
          d5t.SetNormal("green");
          d5b.SetNormal("green");
          d5c.SetNormal("green");
          d5d.SetNormal("green");
          d5e.SetNormal("green");
          d5f.SetNormal("green");
          d5g.SetNormal("green");
          if (_z1Recorder)
          {
            d5Boss.SetNormal("green");
          }
          else
          {
            d5Boss.SetNormal("red");
          }
        }
        else
        {
          d5f.SetNormal("red");
          d5g.SetNormal("red");
          d5z.SetNormal("red");
          d5b.SetNormal("red");
          d5c.SetNormal("red");
          d5d.SetNormal("red");
          d5e.SetNormal("red");
        }
      }
      else
      {
        d5f.SetNormal("red");
        d5g.SetNormal("red");
        d5a.SetNormal("red");
        d5h.SetNormal("red");
        d5i.SetNormal("red");
        d5q.SetNormal("red");
        d5t.SetNormal("red");
        d5z.SetNormal("red");
        d5x.SetNormal("red");
        d5b.SetNormal("red");
        d5c.SetNormal("red");
        d5d.SetNormal("red");
        d5e.SetNormal("red");
        d5Boss.SetNormal("red");
      }

      if (_canKillWizzrobes)
      {
        d6a.SetNormal("green");
        d6b.SetNormal("green");
        d6c.SetNormal("green");
        d6g.SetNormal("green");
        d6h.SetNormal("green");
        d6i.SetNormal("green");
        d6q.SetNormal("green");
        if (_z1Ladder)
        {
          d6d.SetNormal("green");

          d6e.SetNormal("green");
          d6f.SetNormal("green");
          if (_z1Bow && _z1Airrows)
          {
            d6Boss.SetNormal("green");
          }
          else
          {
            d6Boss.SetNormal("red");
          }
        }
        else
        {
          d6d.SetNormal("blue");
          d6e.SetNormal("red");
          d6f.SetNormal("red");
        }
      }
      else
      {
        d6q.SetNormal("red");
        d6d.SetNormal("red");
        d6b.SetNormal("red");
        d6q.SetNormal("red");
        d6e.SetNormal("red");
        d6f.SetNormal("red");
        d6Boss.SetNormal("red");
        d6a.SetNormal("red");
        d6c.SetNormal("red");
        d6g.SetNormal("red");
        d6h.SetNormal("red");
        d6i.SetNormal("red");
      }

      if (_canKillMostZ1Things && _z1Recorder)
      {
        d7a.SetNormal("green");
        d7c.SetNormal("green");
        d7d.SetNormal("green");
        d7e.SetNormal("green");
        d7f.SetNormal("green");
        d7g.SetNormal("yellow");
        d7h.SetNormal("green");

        if (_z1Recorder && _canKillBosses)
        {
          d7b.SetNormal("green");
        }
        else
        {
          d7b.SetNormal("red");
        }

        if (_z1Ladder)
        {
          d7i.SetNormal("green");
          d7x.SetNormal("green");

          if (_z1Meat)
          {
            d7q.SetNormal("yellow");
            d7s.SetNormal("green");
            d7t.SetNormal("green");
            d7u.SetNormal("green");
            d7v.SetNormal("green");


            d7z.SetNormal("green");
            if (_z1Recorder)
            {
              d7y.SetNormal("green");
              d7Boss.SetNormal("green");
            }
            else
            {
              d7Boss.SetNormal("red");
              d7y.SetNormal("red");
            }

          }
          else
          {
            d7s.SetNormal("red");
            d7t.SetNormal("red");
            d7u.SetNormal("red");
            d7v.SetNormal("red");
            d7y.SetNormal("red");
            d7z.SetNormal("red");
            d7Boss.SetNormal("red");
          }

        }
        else
        {
          d7i.SetNormal("red");
          d7q.SetNormal("red");
          d7s.SetNormal("red");
          d7t.SetNormal("red");
          d7u.SetNormal("red");
          d7v.SetNormal("red");
          d7x.SetNormal("red");
          d7y.SetNormal("red");
          d7z.SetNormal("red");
        }
      }
      else
      {
        d7Boss.SetNormal("red");
        d7i.SetNormal("red");
        d7q.SetNormal("red");
        d7s.SetNormal("red");
        d7t.SetNormal("red");
        d7u.SetNormal("red");
        d7v.SetNormal("red");
        d7x.SetNormal("red");
        d7y.SetNormal("red");
        d7b.SetNormal("red");
        d7a.SetNormal("red");
        d7c.SetNormal("red");
        d7d.SetNormal("red");
        d7e.SetNormal("red");
        d7f.SetNormal("red");
        d7g.SetNormal("red");
        d7h.SetNormal("red");
        d7z.SetNormal("red");
      }

      if (_canKillMostZ1Things && _z1Candle)
      {
        d8a.SetNormal("green");
        d8b.SetNormal("green");
        d8h.SetNormal("green");
        d8t.SetNormal("green");
        d8c.SetNormal("green");
        if (_canKillDarknuts)
        {
          d8d.SetNormal("green");
          d8f.SetNormal("green");
          d8i.SetNormal("green");
          d8q.SetNormal("green");
          d8x.SetNormal("green");
          d8z.SetNormal("green");
          d8v.SetNormal("green");
          d8y.SetNormal("green");
          d8g.SetNormal("green");
          if (_canKillGleeok)
          {
            d8Boss.SetNormal("green");
          }
          else
          {
            d8Boss.SetNormal("red");
          }

          if (_z1Bow && _z1Airrows)
          {
            d8e.SetNormal("green");
            d8u.SetNormal("green");
          }
          else
          {
            d8e.SetNormal("red");
            d8u.SetNormal("red");
          }
        }
        else
        {
          d8g.SetNormal("red");
          d8d.SetNormal("red");
          d8f.SetNormal("red");
          d8i.SetNormal("red");
          d8q.SetNormal("red");
          d8x.SetNormal("red");
          d8z.SetNormal("red");
          d8v.SetNormal("red");
          d8y.SetNormal("red");
        }
      }
      else
      {
        d8g.SetNormal("red");
        d8c.SetNormal("red");
        d8a.SetNormal("red");
        d8b.SetNormal("red");
        d8h.SetNormal("red");
        d8t.SetNormal("red");
        d8d.SetNormal("red");
        d8f.SetNormal("red");
        d8i.SetNormal("red");
        d8q.SetNormal("red");
        d8x.SetNormal("red");
        d8z.SetNormal("red");
        d8v.SetNormal("red");
        d8y.SetNormal("red");
        d8e.SetNormal("red");
        d8u.SetNormal("red");
        d8Boss.SetNormal("red");
      }

  }
  }


      
       

