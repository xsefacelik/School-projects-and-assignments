# Where stopwords are listed.
stopper_words = """
able
about
above
abroad
according
accordingly
across
actually
adj
after
afterwards
again
against
ago
ahead
ain't
all
allow
allows
almost
alone
along
alongside
already
also
although
always
am
amid
amidst
among
amongst
an
and
another
any
anybody
anyhow
anyone
anything
anyway
anyways
anywhere
apart
appear
appreciate
appropriate
are
aren't
around
as
a's
aside
ask
asking
associated
at
available
away
awfully
back
backward
backwards
be
became
because
become
becomes
becoming
been
before
beforehand
begin
behind
being
believe
below
beside
besides
best
better
between
beyond
both
brief
but
by
came
can
cannot
cant
can't
caption
cause
causes
certain
certainly
changes
clearly
c'mon
co
co.
com
come
comes
concerning
consequently
consider
considering
contain
containing
contains
corresponding
could
couldn't
course
c's
currently
dare
daren't
definitely
described
despite
did
didn't
different
directly
do
does
doesn't
doing
done
don't
down
downwards
during
each
edu
eg
eight
eighty
either
else
elsewhere
end
ending
enough
entirely
especially
et
etc
even
ever
evermore
every
everybody
everyone
everything
everywhere
ex
exactly
example
except
fairly
far
farther
few
fewer
fifth
first
five
followed
following
follows
for
forever
former
formerly
forth
forward
found
four
from
further
furthermore
get
gets
getting
given
gives
go
goes
going
gone
got
gotten
greetings
had
hadn't
half
happens
hardly
has
hasn't
have
haven't
having
he
he'd
he'll
hello
help
hence
her
here
hereafter
hereby
herein
here's
hereupon
hers
herself
he's
hi
him
himself
his
hither
hopefully
how
howbeit
however
hundred
i'd
ie
if
ignored
i'll
i'm
immediate
in
inasmuch
inc
inc.
indeed
indicate
indicated
indicates
inner
inside
insofar
instead
into
inward
is
isn't
it
it'd
it'll
its
it's
itself
i've
just
k
keep
keeps
kept
know
known
knows
last
lately
later
latter
latterly
least
less
lest
let
let's
like
liked
likely
likewise
little
look
looking
looks
low
lower
ltd
made
mainly
make
makes
many
may
maybe
mayn't
me
mean
meantime
meanwhile
merely
might
mightn't
mine
minus
miss
more
moreover
most
mostly
mr
mrs
much
must
mustn't
my
myself
name
namely
nd
near
nearly
necessary
need
needn't
needs
neither
never
neverf
neverless
nevertheless
new
next
nine
ninety
no
nobody
non
none
nonetheless
noone
no-one
nor
normally
not
nothing
notwithstanding
novel
now
nowhere
obviously
of
off
often
oh
ok
okay
old
on
once
one
ones
one's
only
onto
opposite
or
other
others
otherwise
ought
oughtn't
our
ours
ourselves
out
outside
over
overall
own
particular
particularly
past
per
perhaps
placed
please
plus
possible
presumably
probably
provided
provides
que
quite
qv
rather
rd
re
really
reasonably
recent
recently
regarding
regardless
regards
relatively
respectively
right
round
said
same
saw
say
saying
says
second
secondly
see
seeing
seem
seemed
seeming
seems
seen
self
selves
sensible
sent
serious
seriously
seven
several
shall
shan't
she
she'd
she'll
she's
should
shouldn't
since
six
so
some
somebody
someday
somehow
someone
something
sometime
sometimes
somewhat
somewhere
soon
sorry
specified
specify
specifying
still
sub
such
sup
sure
take
taken
taking
tell
tends
th
than
thank
thanks
thanx
that
that'll
thats
that's
that've
the
their
theirs
them
themselves
then
thence
there
thereafter
thereby
there'd
therefore
therein
there'll
there're
theres
there's
thereupon
there've
these
they
they'd
they'll
they're
they've
thing
things
think
third
thirty
this
thorough
thoroughly
those
though
three
through
throughout
thru
thus
till
to
together
too
took
toward
towards
tried
tries
truly
try
trying
t's
twice
two
un
under
underneath
undoing
unfortunately
unless
unlike
unlikely
until
unto
up
upon
upwards
us
use
used
useful
uses
using
usually
v
value
various
versus
very
via
viz
vs
want
wants
was
wasn't
way
we
we'd
welcome
well
we'll
went
were
we're
weren't
we've
what
whatever
what'll
what's
what've
when
whence
whenever
where
whereafter
whereas
whereby
wherein
where's
whereupon
wherever
whether
which
whichever
while
whilst
whither
who
who'd
whoever
whole
who'll
whom
whomever
who's
whose
why
will
willing
wish
with
within
without
wonder
won't
would
wouldn't
yes
yet
you
you'd
you'll
your
you're
yours
yourself
yourselves
you've
zero
a
how's
i
when's
why's
b
c
d
e
f
g
h
j
l
m
n
o
p
q
r
s
t
u
uucp
w
x
y
z
I
www
amount
bill
bottom
call
computer
con
couldnt
cry
de
describe
detail
due
eleven
empty
fifteen
fifty
fill
find
fire
forty
front
full
give
hasnt
herse
himse
interest
itse”
mill
move
myse”
part
put
show
side
sincere
sixty
system
ten
thick
thin
top
twelve
twenty
abst
accordance
act
added
adopted
affected
affecting
affects
ah
announce
anymore
apparently
approximately
aren
arent
arise
auth
beginning
beginnings
begins
biol
briefly
ca
date
ed
effect
et-al
ff
fix
gave
giving
heres
hes
hid
home
id
im
immediately
importance
important
index
information
invention
itd
keys
kg
km
largely
lets
line
'll
means
mg
million
ml
mug
na
nay
necessarily
nos
noted
obtain
obtained
omitted
ord
owing
page
pages
poorly
possibly
potentially
pp
predominantly
present
previously
primarily
promptly
proud
quickly
ran
readily
ref
refs
related
research
resulted
resulting
results
run
sec
section
shed
shes
showed
shown
showns
shows
significant
significantly
similar
similarly
slightly
somethan
specifically
state
states
stop
strongly
substantially
successfully
sufficiently
suggest
thered
thereof
therere
thereto
theyd
theyre
thou
thoughh
thousand
throug
til
tip
ts
ups
usefully
usefulness
've
vol
vols
wed
whats
wheres
whim
whod
whos
widely
words
world
youd
youre
"""
stopper_words = stopper_words.split("\n")
stopper_words.remove("")


# Scan function for single book.
# Our first parameter is the extension of the txt file, our second parameter is the number of words to be scanned, and
# our third parameter is the name of the file we will print out.
def one_book_searching(file_extention, words_size, your_result_txt):
    file_extention = str(file_extention)

    # Error catching block when word size is not a number.
    try:
        words_size = int(words_size)
    except:
        print("Word size should be an integer.")
        exit()

    # Single search section.
    if not 0 < words_size < 3:
        raise Exception("Word size should be 1 or 2!")


    if words_size == 1:
        # Opening the book to be read and converting it to lowercase.
        try:
            book = open(file_extention, 'r', encoding='utf-8')
            book_string = book.read()
            book_string = book_string.lower()
        except FileNotFoundError:
            print("File extension not found.")
            exit()


        # Generating the removal list of non-alphabetic symbols.
        non_alphanumeric_char = "\n ` ! @ # $ % ^ & * ( ) _ - — + = { } [ ] | \ : ; < , > . ? / “ 0 1 2 3 4 5 6 7 8 9"
        non_alphanumeric_char_list = non_alphanumeric_char.split(" ")


        # Deleting non-alphabetic characters and spaces from txt.
        book_string = book_string.replace("\n", " ")
        for char in non_alphanumeric_char_list:
            book_string = book_string.replace(char, "")


        # Splitting and listing the final version of Txt from spaces.
        book_words_list = book_string.split(" ")


        # Creating a list of stopwords.
        for word in stopper_words:
            for i in range(book_words_list.count(word)):
                book_words_list.remove(word)

        # Converting the book list to a set and getting rid of repeated words.
        book_words_list_once_set = set(book_words_list)
        book_words_list_once_list = list(book_words_list_once_set)


        # Creating a dictionary of how many times each word is repeated.
        book_words_counters_dict = {}
        for once_word in book_words_list_once_list:
            number_of_once_word = book_words_list.count(once_word)
            book_words_counters_dict[once_word] = number_of_once_word


        # Sorting the word repetition dictionary.
        book_words_counters_dict_sorted = {}
        book_words_counters_dict_values_list = list(book_words_counters_dict.values())
        book_words_counters_dict_keys_list = list(book_words_counters_dict.keys())
        for number in book_words_counters_dict_values_list:
            max_value = max(book_words_counters_dict_values_list)
            max_value_index = book_words_counters_dict_values_list.index(max_value)
            book_words_counters_dict_sorted[book_words_counters_dict_keys_list[max_value_index]] = max_value
            book_words_counters_dict_values_list.pop(max_value_index)
            book_words_counters_dict_keys_list.pop(max_value_index)
            max_value -= max_value


        # Writing a single word scan result to a file.
        your_result_txt = open(your_result_txt, 'w', encoding='utf-8')

        # Determination of longest word so spaces can be adjusted.
        size_for_max_word = 0
        for word in book_words_list_once_list:
            word_len = len(word)
            if word_len > size_for_max_word:
                size_for_max_word = word_len

        # Creating the table by the longest word.
        if size_for_max_word > 8:
            your_result_txt.write("| WORD      | WORD" + " " * (size_for_max_word - 3) + "|\n")
            your_result_txt.write("| ORDER     | ORDER" + " " * (size_for_max_word - 4) + "|\n")
            your_result_txt.write("| FREQUENCY | SEQUENCE" + " " * (size_for_max_word - 7) + "|\n")
            your_result_txt.write("|" + "-" * (22 + (size_for_max_word - 8)) + "|\n")
        else:
            your_result_txt.write("| WORD      | WORD     |\n")
            your_result_txt.write("| ORDER     | ORDER    |\n")
            your_result_txt.write("| FREQUENCY | SEQUENCE |\n")
            your_result_txt.write("|" + "-" * 20 + "|\n")

        book_sorted_items_list = list(book_words_counters_dict_sorted.items())
        for item in book_sorted_items_list:
            your_result_txt.write("| " + str(item[1]) + " " * (10 - len(str(item[1]))) + "| " + item[0] + " " * (size_for_max_word - len(item[0]) + 1) + "|\n")

    # Binary search section.
    elif words_size == 2:
        # Opening the book to be read and converting it to lowercase.
        try:
            book = open(file_extention, 'r', encoding='utf-8')
            book_string = book.read()
            book_string = book_string.lower()
        except FileNotFoundError:
            print("File extension not found.")
            exit()

        # Generating the removal list of non-alphabetic symbols.
        non_alphanumeric_char = " '\n' ' ` ! @ # $ % ^ & * ( ) _ - — + = { } [ ] | \ : ; < , > . ? / “ 0 1 2 3 4 5 6 7 8 9"
        non_alphanumeric_char_list = non_alphanumeric_char.split(" ")


        # Deleting non-alphabetic characters and spaces from txt.
        book_string = book_string.replace("\n", " ")
        for char in non_alphanumeric_char_list:
            book_string = book_string.replace(char, "")


        # Splitting and listing the final version of Txt from spaces.
        book_words_list = book_string.split(" ")
        for i in range(book_words_list.count("")):
            book_words_list.remove("")


        # Creating a list of stopwords.
        for word in stopper_words:
            for i in range(book_words_list.count(word)):
                book_words_list.remove(word)


        # Creation of binary word groups.
        book_word_double_list = []
        for i in range(len(book_words_list) - 1):
            list_words = []
            list_words.append(book_words_list[i])
            list_words.append(book_words_list[i + 1])
            str_list_words = "" + list_words[0] + " " + list_words[1]
            book_word_double_list.append(str_list_words)


        # Converting the book list to a set and getting rid of repeated words.
        book_word_double_once_set = set(book_word_double_list)
        book_word_double_once_list = list(book_word_double_once_set)


        # Creating a dictionary of how many times each word is repeated.
        book_words_double_counters_dict = {}
        for once_word in book_word_double_once_set:
            number_of_once_word = book_word_double_list.count(once_word)
            book_words_double_counters_dict[once_word] = number_of_once_word


        # Sorting the word repetition dictionary.
        book_words_counters_dict_sorted = {}
        book_words_double_counters_dict_values_list = list(book_words_double_counters_dict.values())
        book_words_double_counters_dict_keys_list = list(book_words_double_counters_dict.keys())
        for number in book_words_double_counters_dict_values_list:
            max_value = max(book_words_double_counters_dict_values_list)
            max_value_index = book_words_double_counters_dict_values_list.index(max_value)
            book_words_counters_dict_sorted[book_words_double_counters_dict_keys_list[max_value_index]] = max_value
            book_words_double_counters_dict_values_list.pop(max_value_index)
            book_words_double_counters_dict_keys_list.pop(max_value_index)
            max_value -= max_value


        # Writing the binary word scan result to a file.
        your_result_txt = open(your_result_txt, 'w', encoding='utf-8')

        # Determination of longest word so spaces can be adjusted.
        size_for_max_word = 0
        for word in book_word_double_once_list:
            word_len = len(word)
            if word_len > size_for_max_word:
                size_for_max_word = word_len

        #  Creating the table by the longest word.
        if size_for_max_word > 8:
            your_result_txt.write("| Word      | Word" + " " * (size_for_max_word - 3) + "|\n")
            your_result_txt.write("| Order     | Order" + " " * (size_for_max_word - 4) + "|\n")
            your_result_txt.write("| Frequency | Sequence" + " " * (size_for_max_word - 7) + "|\n")
            your_result_txt.write("|" + "-" * (22 + (size_for_max_word - 8)) + "|\n")
        else:
            your_result_txt.write("| Word      | Word     |\n")
            your_result_txt.write("| Order     | Order    |\n")
            your_result_txt.write("| Frequency | Sequence |\n")
            your_result_txt.write("|" + "-" * 20 + "|\n")

        book_sorted_items_list = list(book_words_counters_dict_sorted.items())
        for item in book_sorted_items_list:
            your_result_txt.write("| " + str(item[1]) + " " * (10 - len(str(item[1]))) + "| " + item[0] + " " * (size_for_max_word - len(item[0]) + 1) + "|\n")


# Function that will scan for two books.
# Our first and second parameters are the extensions of the txt files to be scanned, our third parameter is
# how many words will be searched and our third parameter will be the name of the file from which we will print.
def two_book_operations (file_extention_1, file_extention_2, words_size, your_result_txt):
    # Single search section.
    if not 0 < words_size < 3:
        raise Exception("Word size should be 1 or 2!")

    if words_size == 1:
        # Opening the first book to be read and converting it to lowercase.
        try:
            book_1 = open(file_extention_1, 'r', encoding='utf-8')
            book_1_string = book_1.read()
            book_1_string = book_1_string.lower()
        except:
            print("File extension not found.")
            exit()

        # Opening the second book to be read and converting it to lowercase
        try:
            book_2 = open(file_extention_2, 'r', encoding='utf-8')
            book_2_string = book_2.read()
            book_2_string = book_2_string.lower()
        except:
            print("File extension not found.")
            exit()


        # Generating the removal list of non-alphabetic symbols.
        non_alphanumeric_char = "\n ` ! @ # $ % ^ & * ( ) _ - — + = { } [ ] | \ : ; < , > . ? / “ 0 1 2 3 4 5 6 7 8 9"
        non_alphanumeric_char_list = non_alphanumeric_char.split(" ")


        # Deleting non-alphabetic and spaces from txt
        book_1_string = book_1_string.replace("\n", " ")
        for char in non_alphanumeric_char_list:
            book_1_string = book_1_string.replace(char, "")

        book_2_string = book_2_string.replace("\n", " ")
        for char in non_alphanumeric_char_list:
            book_2_string = book_2_string.replace(char, "")


        # Splitting and listing the final version of Txt from spaces.
        book_1_words_list = book_1_string.split(" ")
        book_2_words_list = book_2_string.split(" ")


        # Deleting stopwords.
        for word in stopper_words:
            for i in range(book_1_words_list.count(word)):
                book_1_words_list.remove(word)
        for word in stopper_words:
            for i in range(book_2_words_list.count(word)):
                book_2_words_list.remove(word)


        # Converting the book list to a set and getting rid of repeated words.
        book_1_words_list_once_set = set(book_1_words_list)
        book_1_words_list_once_list = list(book_1_words_list_once_set)
        book_2_words_list_once_set = set(book_2_words_list)
        book_2_words_list_once_list = list(book_2_words_list_once_set)


        # Creating a dictionary of how many times each word is repeated.
        book_1_words_counters_dict = {}
        for once_word in book_1_words_list_once_list:
            number_of_once_word = book_1_words_list.count(once_word)
            book_1_words_counters_dict[once_word] = number_of_once_word
        book_2_words_counters_dict = {}
        for once_word in book_2_words_list_once_list:
            number_of_once_word = book_2_words_list.count(once_word)
            book_2_words_counters_dict[once_word] = number_of_once_word


        # Sorting the word repetition dictionary.
        book_1_words_counters_dict_sorted = {}
        book_1_words_counters_dict_values_list = list(book_1_words_counters_dict.values())
        book_1_words_counters_dict_keys_list = list(book_1_words_counters_dict.keys())
        for number in book_1_words_counters_dict_values_list:
            max_value = max(book_1_words_counters_dict_values_list)
            max_value_index = book_1_words_counters_dict_values_list.index(max_value)
            book_1_words_counters_dict_sorted[book_1_words_counters_dict_keys_list[max_value_index]] = max_value
            book_1_words_counters_dict_values_list.pop(max_value_index)
            book_1_words_counters_dict_keys_list.pop(max_value_index)
            max_value -= max_value

        book_2_words_counters_dict_sorted = {}
        book_2_words_counters_dict_values_list = list(book_2_words_counters_dict.values())
        book_2_words_counters_dict_keys_list = list(book_2_words_counters_dict.keys())
        for number in book_2_words_counters_dict_values_list:
            max_value = max(book_2_words_counters_dict_values_list)
            max_value_index = book_2_words_counters_dict_values_list.index(max_value)
            book_2_words_counters_dict_sorted[book_2_words_counters_dict_keys_list[max_value_index]] = max_value
            book_2_words_counters_dict_values_list.pop(max_value_index)
            book_2_words_counters_dict_keys_list.pop(max_value_index)
            max_value -= max_value


        # Writing a single word scan result to a file.
        your_result_txt = open(your_result_txt, 'w', encoding='utf-8')

        # Determination of longest word so spaces can be adjusted.
        size_for_max_word = 0
        for word in book_1_words_list_once_list + book_2_words_list_once_list:
            word_len = len(word)
            if word_len > size_for_max_word:
                size_for_max_word = word_len

        #  Creating the table by the longest word.
        if size_for_max_word > 8:
            your_result_txt.write("| TOTAL     | BOOK 1    | BOOK 2    | WORD " + " " * (size_for_max_word - 4) + "|\n")
            your_result_txt.write("| ORDER     | ORDER     | ORDER     | ORDER " + " " * (size_for_max_word - 5) + "|\n")
            your_result_txt.write("| FREQUENCY | FREQUENCY | FREQUENCY | SEQUENCE " + " " * (size_for_max_word - 8) + "|\n")
            your_result_txt.write("-" * (29 + size_for_max_word + 11) + "\n")
        else:
            your_result_txt.write("| Word      | Word     |\n")
            your_result_txt.write("| Order     | Order    |\n")
            your_result_txt.write("| Frequency | Sequence |\n")
            your_result_txt.write("|" + "-" * 20 + "|\n")


        # Where all the words to be scanned are listed.
        full_words_for_keys = book_1_words_counters_dict_keys_list + book_2_words_counters_dict_keys_list
        full_words_for_keys = set(full_words_for_keys)
        full_words_for_keys_list = list(full_words_for_keys)

        book_1_key_list = list(book_1_words_counters_dict.keys())
        book_2_key_list = list(book_2_words_counters_dict.keys())

        # The part where the word that is in one book but not in the other book is equated to 0
        # in the non-book dictionary and processed.
        for key in book_1_key_list:
            if key not in book_2_key_list:
                book_2_words_counters_dict[key] = 0
        for key in book_2_key_list:
            if key not in book_1_key_list:
                book_1_words_counters_dict[key] = 0

        # Dictionary with count of all words to be scanned.
        full_words_counter_dict = {}
        for word in full_words_for_keys_list:
            full_words_counter_dict[word] = book_1_words_counters_dict[word] + book_2_words_counters_dict[word]

        full_words_counter_dict_sorted = {}
        full_words_counter_dict_values_list = list(full_words_counter_dict.values())
        full_words_counter_dict_keys_list = list(full_words_counter_dict.keys())

        for number in full_words_counter_dict_values_list:
            max_value = max(full_words_counter_dict_values_list)
            max_value_index = full_words_counter_dict_values_list.index(max_value)
            full_words_counter_dict_sorted[full_words_counter_dict_keys_list[max_value_index]] = max_value
            full_words_counter_dict_values_list.pop(max_value_index)
            full_words_counter_dict_keys_list.pop(max_value_index)
            max_value -= max_value

        full_words_counter_dict_sorted_items = list(full_words_counter_dict_sorted.items())
        for item in full_words_counter_dict_sorted_items:
            your_result_txt.write("| " + str(item[1]) + " " * (10 - len(str(item[1]))) + "| " + str(book_1_words_counters_dict[item[0]]) + " " * (10 - len(str(book_1_words_counters_dict[item[0]]))) + "| " + str(book_2_words_counters_dict[item[0]]) + " " * (10 - len(str(book_2_words_counters_dict[item[0]]))) + "| " + item[0] + " " * (size_for_max_word - len((item[0])) + 1) + "|\n")

    # Binary search section.
    elif words_size == 2:
        # Opening the first book to be read and converting it to lowercase.
        try:
            book_1 = open(file_extention_1, 'r', encoding='utf-8')
            book_1_string = book_1.read()
            book_1_string = book_1_string.lower()
        except:
            print("File extension not found.")
            exit()

        # Opening the second book to be read and converting it to lowercase.
        try:
            book_2 = open(file_extention_2, 'r', encoding='utf-8')
            book_2_string = book_2.read()
            book_2_string = book_2_string.lower()
        except:
            print("File extension not found.")
            exit()


        # Generating the removal list of non-alphabetic symbols.
        non_alphanumeric_char = "\n ` ! @ # $ % ^ & * ( ) _ - — + = { } [ ] | \ : ; < , > . ? / “ 0 1 2 3 4 5 6 7 8 9"
        non_alphanumeric_char_list = non_alphanumeric_char.split(" ")


        # Deleting non-alphabetic and spaces from txt.
        book_1_string = book_1_string.replace("\n", " ")
        for char in non_alphanumeric_char_list:
            book_1_string = book_1_string.replace(char, "")

        book_2_string = book_2_string.replace("\n", " ")
        for char in non_alphanumeric_char_list:
            book_2_string = book_2_string.replace(char, "")

        # Splitting and listing the final version of Txt from spaces.
        book_1_words_list = book_1_string.split(" ")
        book_2_words_list = book_2_string.split(" ")

        # Deleting stopwords.
        for word in stopper_words:
            for i in range(book_1_words_list.count(word)):
                book_1_words_list.remove(word)
        for word in stopper_words:
            for i in range(book_2_words_list.count(word)):
                book_2_words_list.remove(word)


        # Creating binary word groups.
        book_1_word_double_list = []
        for i in range(len(book_1_words_list) - 1):
            list_words = []
            list_words.append(book_1_words_list[i])
            list_words.append(book_1_words_list[i + 1])
            str_list_words = "" + list_words[0] + " " + list_words[1]
            book_1_word_double_list.append(str_list_words)

        book_2_word_double_list = []
        for i in range(len(book_2_words_list) - 1):
            list_words = []
            list_words.append(book_2_words_list[i])
            list_words.append(book_2_words_list[i + 1])
            str_list_words = "" + list_words[0] + " " + list_words[1]
            book_2_word_double_list.append(str_list_words)


        # Converting the book list to a set and getting rid of repeated words.
        book_1_word_double_once_set = set(book_1_word_double_list)
        book_1_word_double_once_list = list(book_1_word_double_once_set)
        book_2_word_double_once_set = set(book_2_word_double_list)
        book_2_word_double_once_list = list(book_2_word_double_once_set)


        # Creating a dictionary of how many times each word is repeated.
        book_1_words_double_counters_dict = {}
        for once_word in book_1_word_double_once_set:
            number_of_once_word = book_1_word_double_list.count(once_word)
            book_1_words_double_counters_dict[once_word] = number_of_once_word

        book_2_words_double_counters_dict = {}
        for once_word in book_2_word_double_once_set:
            number_of_once_word = book_2_word_double_list.count(once_word)
            book_2_words_double_counters_dict[once_word] = number_of_once_word


        # Sorting the word repetition dictionary.
        book_1_words_counters_dict_sorted = {}
        book_1_words_double_counters_dict_values_list = list(book_1_words_double_counters_dict.values())
        book_1_words_double_counters_dict_keys_list = list(book_1_words_double_counters_dict.keys())
        for number in book_1_words_double_counters_dict_values_list:
            max_value = max(book_1_words_double_counters_dict_values_list)
            max_value_index = book_1_words_double_counters_dict_values_list.index(max_value)
            book_1_words_counters_dict_sorted[book_1_words_double_counters_dict_keys_list[max_value_index]] = max_value
            book_1_words_double_counters_dict_values_list.pop(max_value_index)
            book_1_words_double_counters_dict_keys_list.pop(max_value_index)
            max_value -= max_value

        book_2_words_counters_dict_sorted = {}
        book_2_words_double_counters_dict_values_list = list(book_2_words_double_counters_dict.values())
        book_2_words_double_counters_dict_keys_list = list(book_2_words_double_counters_dict.keys())
        for number in book_2_words_double_counters_dict_values_list:
            max_value = max(book_2_words_double_counters_dict_values_list)
            max_value_index = book_2_words_double_counters_dict_values_list.index(max_value)
            book_2_words_counters_dict_sorted[book_2_words_double_counters_dict_keys_list[max_value_index]] = max_value
            book_2_words_double_counters_dict_values_list.pop(max_value_index)
            book_2_words_double_counters_dict_keys_list.pop(max_value_index)
            max_value -= max_value


        # writing two word scan results to a file.
        your_result_txt = open(your_result_txt, 'w', encoding='utf-8')

        # Determination of longest word so spaces can be adjusted.
        size_for_max_word = 0
        for word in book_1_word_double_once_list + book_2_word_double_once_list:
            word_len = len(word)
            if word_len > size_for_max_word:
                size_for_max_word = word_len

        #  Creating the table by the longest word.
        if size_for_max_word > 8:
            your_result_txt.write("| TOTAL     | BOOK 1    | BOOK 2    | WORD " + " " * (size_for_max_word - 4) + "|\n")
            your_result_txt.write("| ORDER     | ORDER     | ORDER     | ORDER " + " " * (size_for_max_word - 5) + "|\n")
            your_result_txt.write("| FREQUENCY | FREQUENCY | FREQUENCY | SEQUENCE " + " " * (size_for_max_word - 8) + "|\n")
            your_result_txt.write("-" * (29 + size_for_max_word + 11) + "\n")
        else:
            your_result_txt.write("| Word      | Word     |\n")
            your_result_txt.write("| Order     | Order    |\n")
            your_result_txt.write("| Frequency | Sequence |\n")
            your_result_txt.write("|" + "-" * 20 + "|\n")


        # Where all the binary words to be scanned are listed.
        full_words_double_for_keys = book_1_words_double_counters_dict_keys_list + book_2_words_double_counters_dict_keys_list
        full_words_double_for_keys = set(full_words_double_for_keys)
        full_words_double_for_keys_list = list(full_words_double_for_keys)

        book_1_double_key_list = list(book_1_words_double_counters_dict.keys())
        book_2_double_key_list = list(book_2_words_double_counters_dict.keys())

        # The part where the binary word that is in one book but not in the other book is equated to 0
        # in the non-book dictionary and processed.
        for key in book_1_double_key_list:
            if key not in book_2_double_key_list:
                book_2_words_double_counters_dict[key] = 0
        for key in book_2_double_key_list:
            if key not in book_1_double_key_list:
                book_1_words_double_counters_dict[key] = 0


        # Dictionary with count of all words to be scanned.
        full_words_double_counter_dict = {}
        for word in full_words_double_for_keys_list:
            full_words_double_counter_dict[word] = book_1_words_double_counters_dict[word] + book_2_words_double_counters_dict[word]

        full_words_double_counter_dict_sorted = {}
        full_words_double_counter_dict_values_list = list(full_words_double_counter_dict.values())
        full_words_double_counter_dict_keys_list = list(full_words_double_counter_dict.keys())

        for number in full_words_double_counter_dict_values_list:
            max_value = max(full_words_double_counter_dict_values_list)
            max_value_index = full_words_double_counter_dict_values_list.index(max_value)
            full_words_double_counter_dict_sorted[full_words_double_counter_dict_keys_list[max_value_index]] = max_value
            full_words_double_counter_dict_values_list.pop(max_value_index)
            full_words_double_counter_dict_keys_list.pop(max_value_index)
            max_value -= max_value

        full_words_counter_dict_sorted_items = list(full_words_double_counter_dict_sorted.items())
        for item in full_words_counter_dict_sorted_items:
            your_result_txt.write("| " + str(item[1]) + " " * (10 - len(str(item[1]))) + "| " + str(book_1_words_double_counters_dict[item[0]]) + " " * (10 - len(str(book_1_words_double_counters_dict[item[0]]))) + "| " + str(book_2_words_double_counters_dict[item[0]]) + " " * (10 - len(str(book_2_words_double_counters_dict[item[0]]))) + "| " + item[0] + " " * (size_for_max_word - len((item[0])) + 1) + "|\n")

        one_book_searching("C:\\Users\\SEFA\\Desktop\\Book_1.txt", 1, "Son deneme")