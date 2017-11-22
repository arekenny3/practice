

import re


print("Phone Number Example")
phone = "2004-959-559 # This is Phone Number"
# Delete Python-style comments
num = re.sub(r'#.*$', "", phone)
print("Phone Num : ", num)

# Remove anything other than digits
num = re.sub(r'\D', "", phone)    
print("Phone Num : ", num)



print("\n\n")


# List of patterns to search for
  #Input patterns
# patterns = []
# maxLength = 6
# while len(patterns) < maxLength:
#   wpat = input("Enter word: ")
#   patterns.append(wpat)
#   print(patterns)

add = []
  #Default Patterns
patterns = ['term1', 'term2','mac','hws','HWS']
# Text to parse

  # Input String
text = input("Type something: ")
  # Default String
#text = 'This is a string with term1, but it does not have the other term.'

for pattern in patterns:
    print('Searching for "%s" in: \n"%s"' % (pattern, text))
    
    #Check for match
    word = 'HWS'
    
    #split text!!
    x = text.split()
    
    
    if re.search(word, text):
          add.append(str(word + 'ish'))
          #print(add.append(word))
          #print(add)
    elif re.search(pattern, text):
          print('\n')
          print('Match was found. \n')
          add.append(pattern)
    
    else:
        print('\n')
        print('No Match was found.\n')
        continue
print(add)
        
        
        
# l = ['hector', 'gerald', ['tomato', 'potato']]
# print(l[2])
# print('\n\n\n')
# print("NUMBER 2!!")

# # List of patterns to search for
# pattern = 'term1'

# # Text to parse
# text = 'This is a string with term1, but it does not have the other term.'

# match = re.search(pattern,  text)

# print(type(match))
# print(match.start())
# print(match.end())




print('\n\n\n')


# # Term to split on
# split_term = '@'

# phrase = 'What is the domain name of someone with the email: hello@gmail.com'

# # Split the phrase
# re.split(split_term,phrase)


# print('\n\n\n')
# print("NUMBER 4!!")

# # Returns a list of all matches
# re.findall('match','test phrase match is in middle')





# def multi_re_find(patterns,phrase):
#     '''
#     Takes in a list of regex patterns
#     Prints a list of all matches
#     '''
#     for pattern in patterns:
#         print('Searching the phrase using the re check: %r' %pattern)
#         print(re.findall(pattern,phrase))
#         print('\n')

#   #User Input
# # test_phrase = input('Type something ') 
#   # Default
# test_phrase = 'sdsd..sssddd...sdddsddd...dsds...dsssss...sdddd'


# test_patterns = [ 'sd*',     # s followed by zero or more d's
#                 'sd+',          # s followed by one or more d's
#                 'sd?',          # s followed by zero or one d's
#                 'sd{3}',        # s followed by three d's
#                 'sd{2,3}',      # s followed by two to three d's
#                 ]
# print(test_phrase,'\n\n\n')
# multi_re_find(test_patterns,test_phrase)




# test_patterns = [ '[sd]',    # either s or d
#             's[sd]+']   # s followed by one or more s or d
            

# multi_re_find(test_patterns,test_phrase)




# test_phrase = 'This is a string! But it has punctuation. How can we remove it?'

# re.findall('[^!.? ]+',test_phrase) 





# test_phrase = 'This is an example sentence. Lets see if we can find some letters.'

# test_patterns=[ '[a-z]+',      # sequences of lower case letters
#                 '[A-Z]+',      # sequences of upper case letters
#                 '[a-zA-Z]+',   # sequences of lower or upper case letters
#                 '[A-Z][a-z]+'] # one upper case letter followed by lower case letters
                
# multi_re_find(test_patterns,test_phrase)



# test_phrase = 'This is a string with some numbers 1233 and a symbol #hashtag'

# test_patterns=[ r'\d+', # sequence of digits
#                 r'\D+', # sequence of non-digits
#                 r'\s+', # sequence of whitespace
#                 r'\S+', # sequence of non-whitespace
#                 r'\w+', # alphanumeric characters
#                 r'\W+', # non-alphanumeric
#                 ]

# multi_re_find(test_patterns,test_phrase)

