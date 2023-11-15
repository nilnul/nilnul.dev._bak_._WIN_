# nilnul bak
(codename: nilnul.dev.\_bak\_.\_WIN\_)

Automatically bak (backup) your local repos to a collection of remote servers, such that you files would never get lost;

## key features
It can
- automatically name your repo if you follow a specified structure; so you can just put your repo in a certain location, and this software can handle the rest for you (you even don't need to init it!);
- create corresponding repo on the server;
- create a bak branch in your local repo to keep your work-in-process before pushing it to the servers;
- push also other branches;
- push some branches you named as `pub-*` to the pub servers as you configurated; this is useful if some repo is open source one;

## development
This currently targets dotnet framework 4.8.1; 

To develop this:
- download this repo into a folder named, say, <var>nilnul.dev.\_bak\_</var>;
- also download <var>nilnul.dev.\_bak\_.\_LIB\_</var> and <dfn>nilnul.dev.\_bak\_.\_CTR\_</dfn> into that folder; <dfn>nilnul.dev.\_bak\_.\_WIN\_</dfn> is the winForm appliction, which need to “project reference” <dfn>nilnul.dev.\_bak\_.\_LIB\_</dfn> and <dfn>nilnul.dev.\_bak\_.\_CTR\_</dfn>; 
- other dependencies shall be automatically restored when you build;
- now you can run;

## run
To run this, you need some configurations:
- configure a collection of disjoint folders as srcs; under each src, every repo is named after its relative path to the src;
- configure a collection of remote servers; we now support github, gitlab, azure, amazon; 
  For some regions in east asia, github connection is not stable, so it's defaulted to ssh for pushing; for other regions, the connection can be, in our plan, defaulted to https;
- click menu "Bak -> Folders -> Srcs", your configurated srcs shall appear there; click start to begin the bakking process;

This software is currently in preview; if you have any question, open an issue;


### Manual
Currently there is a user manual in Chinese:
http://nilnul.com/app_/nilnul._dev_._bak_.WIN._MAN_/

You can use browser to translate it. The English version is on the way.

## Licensing
Free for personal noncommercial use.
For commercial use, the initial 6 months are free, and $10 per core per year afterwards.

Commercial use means:
- it is installed on a computer owned by an organization, not a person;
- or it's used as part of or in the process of a commoditiy/service that is for sale;
